using Binary_Sentiment_Analysis;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Text;
using static Microsoft.ML.DataOperationsCatalog;

string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "yelp_labelled.txt");

//Create MLContext to be shared across the model creation workflow objects
MLContext mlContext = new MLContext();

// 1. Load Data
TrainTestData splitDataView = LoadData(mlContext);

// 2. Build and Train Model
ITransformer model = BuildAndTrainModel(mlContext, splitDataView.TrainSet);

// 3. Evaluate accuracy of Model
Evaluate(mlContext, model, splitDataView.TestSet);

// 4. Use the model with a single item to make a prediction
UseModelWithSingleItem(mlContext, model);

// 5. Use the model with a batch of items to make predictions
UseModelWithBatchItems(mlContext, model);


TrainTestData LoadData(MLContext mlContext)
{
    IDataView dataView = mlContext.Data.LoadFromTextFile<SentimentData>(_dataPath, hasHeader: false);
    TrainTestData splitDataView = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

    return splitDataView;
}

ITransformer BuildAndTrainModel(MLContext mlContext, IDataView splitTrainSet)
{
    //Explicitly set the options for the TextFeaturizingEstimator to use n-grams of length 2 and not use all lengths
    var options = new TextFeaturizingEstimator.Options
    {
        WordFeatureExtractor = new WordBagEstimator.Options
        {
            NgramLength = 2,
            UseAllLengths = false
        },
        CharFeatureExtractor = null
    };

    var estimator = mlContext.Transforms.Text.FeaturizeText(
        outputColumnName: "Features",
        options: options,
        inputColumnNames: new[] { nameof(SentimentData.SentimentText) })
        .Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(
            labelColumnName: "Label", 
            featureColumnName: "Features"));

    Console.WriteLine("=============== Create and Train the Model ===============");
    var model = estimator.Fit(splitTrainSet);
    Console.WriteLine("=============== End of training ===============");
    Console.WriteLine();

    return model;
}

void Evaluate(MLContext mlContext, ITransformer model, IDataView splitTestSet)
{
    Console.WriteLine("=============== Evaluating Model accuracy with Test data===============");
    IDataView predictions = model.Transform(splitTestSet);

    CalibratedBinaryClassificationMetrics metrics = mlContext.BinaryClassification.Evaluate(predictions, "Label");

    Console.WriteLine();
    Console.WriteLine("Model quality metrics evaluation");
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Accuracy: {metrics.Accuracy:P2}");
    Console.WriteLine($"Auc: {metrics.AreaUnderRocCurve:P2}");
    Console.WriteLine($"F1Score: {metrics.F1Score:P2}");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("=============== End of model evaluation ===============");
}

void UseModelWithSingleItem(MLContext mlContext, ITransformer model)
{
    PredictionEngine<SentimentData, SentimentPrediction> predictionFunction = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model);

    var sampleData = new SentimentData
    {
        SentimentText = "This movie is great!"
    };

    var prediction = predictionFunction.Predict(sampleData);

    Console.WriteLine();
    Console.WriteLine("=============== Prediction Test of model with a single sample and test dataset ===============");
    Console.WriteLine($"Sentiment: {prediction.SentimentText} | Prediction: {(Convert.ToBoolean(prediction.Prediction) ? "Positive" : "Negative")} | Probability: {prediction.Probability} ");
    Console.WriteLine("=============== End of Prediction ===============");
    Console.WriteLine();
}

void UseModelWithBatchItems(MLContext mlContext, ITransformer model)
{
    IEnumerable<SentimentData> sentiments = new[]
    {
        new SentimentData
        {
            SentimentText = "This was a horrible meal"
        },
        new SentimentData
        {
            SentimentText = "I love this spaghetti."
        },
        new SentimentData
        {
            SentimentText = "I do not like this restaurant"
        },
        new SentimentData
        {
            SentimentText = "I loved the ambient"
        },
        new SentimentData
        {
            SentimentText = "I will never come back"
        },
        new SentimentData
        {
            SentimentText = "I will come back for sure, although it was a bit pricey"
        },
        new SentimentData
        {
            SentimentText = "It was a bit pricey, although I will come back for sure"
        },
        new SentimentData
        {
            SentimentText = "I will come back for sure pricey"
        },
        new SentimentData
        {
            SentimentText = "pricey I will come back for sure"
        }
    };

    //LoadFromEnumerable is used to convert sentiments IEnumerable to IDataView.
    IDataView batchComments = mlContext.Data.LoadFromEnumerable(sentiments);

    IDataView predictions = model.Transform(batchComments);

    // Use model to predict whether comment data is Positive (1) or Negative (0).
    IEnumerable<SentimentPrediction> predictedResults = mlContext.Data.CreateEnumerable<SentimentPrediction>(predictions, reuseRowObject: false);

    Console.WriteLine();
    Console.WriteLine("=============== Prediction Test of loaded model with multiple samples ===============");
    foreach (SentimentPrediction prediction in predictedResults)
    {
        Console.WriteLine($"Sentiment: {prediction.SentimentText} | Prediction: {(Convert.ToBoolean(prediction.Prediction) ? "Positive" : "Negative")} | Probability: {prediction.Probability} ");
    }
    Console.WriteLine("=============== End of predictions ===============");
}