using System;
namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        public TextConnector()
        {
        }

        //TODO - Make the CreatePrize method save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
}
