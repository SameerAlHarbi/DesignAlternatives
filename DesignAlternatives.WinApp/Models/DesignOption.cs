﻿namespace DesignAlternatives.WinApp.Models
{
    public class DesignOption
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }


        #region Space Functionality

        public decimal Accessibility { get; set; }

        public decimal Relation { get; set; }

        public decimal Size { get; set; }

        #endregion

        #region Construction Performance

        public decimal Cost { get; set; }

        public decimal Time { get; set; }

        #endregion

        #region Operation Performance

        public decimal Energy { get; set; }

        public decimal Maintenance { get; set; }

        #endregion

        public decimal Aesthetics { get; set; }

        public decimal Sum => Accessibility + Relation + Size + Cost + Time + Energy + Maintenance + Aesthetics;

        public override string ToString()
        {
            return Name;
        }
    }
}
