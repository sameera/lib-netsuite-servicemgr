using System;

namespace SuiteTalk
{
    public partial class PayrollItemSearchRow: SearchRow<PayrollItemSearchRowBasic>, SupportsCustomSearchJoin
    {
        public PayrollItemSearchRowBasic GetBasic() => this.basic;

        public PayrollItemSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new PayrollItemSearchRowBasic();
            return this.basic;
        }

        public PayrollItemSearchRowBasic CreateBasic(Action<PayrollItemSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return basic;
        }

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        public J CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return join;
        }


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(PayrollItemSearchRow target, string joinName, bool createIfNull = false)
        {
          throw new ArgumentException("PayrollItemSearchRow does not support Joins");
        }
    }
}