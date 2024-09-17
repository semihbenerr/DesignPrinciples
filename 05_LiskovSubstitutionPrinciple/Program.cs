#region NotIdeal
//using _05_LiskovSubstitutionPrinciple.NotIdealCode;
//Cloud cloud = new AWS();
//cloud.MachineLearning();
//cloud.Translate();

//cloud = new Google();
//cloud.MachineLearning();
//cloud.Translate();

//cloud = new Azure();
//cloud.MachineLearning();
//cloud.Translate();
#endregion

#region Ideal
using _05_LiskovSubstitutionPrinciple.IdealCode;
using System.Linq.Expressions;
Cloud cloud = new AWS();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();

cloud = new Google();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();


cloud = new Azure();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();

#endregion