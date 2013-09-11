using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alice.Storefront.Infrastructure.Domain
{
    public class BusinessRule
    {
        private string _property;
        private string _rule;
        public BusinessRule(string property, string rule)
        {
            _property = property;
            _rule = rule;
        }
        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }
        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }
        public string what = "is it?";
    }
}
