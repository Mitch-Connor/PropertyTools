﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestDisplayNameAttribute.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ExampleLibrary
{
    using PropertyTools.DataAnnotations;

    [PropertyGridExample]
    public class TestDisplayNameAttribute : TestBase
    {
        [Category("No attribute")]
        public string Property1 { get; set; }

        [Category("System.ComponentModel")]
        [System.ComponentModel.DisplayName("Customized name (Property2)")]
        public string Property2 { get; set; }

        [Category("PropertyTools.DataAnnotations")]
        [DisplayName("Customized name (Property3)")]
        public string Property3 { get; set; }

        [Category("Derived DisplayNameAttribute")]
        [CustomDisplayName("Property4")]
        public string Property4 { get; set; }

        public override string ToString()
        {
            return "DisplayNameAttribute";
        }

        public class CustomDisplayNameAttribute : DisplayNameAttribute
        {
            public CustomDisplayNameAttribute(string displayName) : base(displayName)
            {
            }

            public override string DisplayName
            {
                get
                {
                    return base.DisplayName.ToUpper();
                }
            }
        }
    }
}