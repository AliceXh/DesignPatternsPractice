using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alice.Storefront.Infrastructure.Domain
{
    public class EntityBase<TId>
    {
        private List<BusinessRule> _brokenRules = new List<BusinessRule>();
        public TId Id { get; set; }
        protected abstract void Validate();
        public IEnumerable<BusinessRule> GetBrokenRules()
        {
            _brokenRules.Clear();
            Validate();
            return _brokenRules;
        }
        protected void AddBrokenRule(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }
        public override bool Equals(object entity)
        {
            return entity != null
                && entity is EntityBase<TId>
                && this == (EntityBase<TId>)entity;
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.Id.GetHashCode();
        }
        public static bool operator ==(EntityBase<TId> t1, EntityBase<TId> t2)
        {
            if ((object)t1 == null && (object)t2 == null)
            {
                return true;
            }
            if ((object)t1 == null || (object)t2 == null)
            {
                return false;
            }
            if (t1.Id.ToString() == t2.Id.ToString())
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(EntityBase<TId> t1, EntityBase<TId> t2)
        {
            return !(t1 == t2);
        }
    }
}
