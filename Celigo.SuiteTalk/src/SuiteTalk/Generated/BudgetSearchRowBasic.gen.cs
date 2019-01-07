//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class BudgetSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<BudgetSearchRowBasic>
        {
            protected override Dictionary<string, Action<BudgetSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<BudgetSearchRowBasic>> {
                    { "account", r => r.@account = new [] { new SearchColumnStringField { customLabel = "account" } } },
                    { "amount", r => r.@amount = new [] { new SearchColumnDoubleField { customLabel = "amount" } } },
                    { "category", r => r.@category = new [] { new SearchColumnStringField { customLabel = "category" } } },
                    { "class", r => r.@class = new [] { new SearchColumnStringField { customLabel = "class" } } },
                    { "classnohierarchy", r => r.@classnohierarchy = new [] { new SearchColumnStringField { customLabel = "classnohierarchy" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnStringField { customLabel = "currency" } } },
                    { "customer", r => r.@customer = new [] { new SearchColumnStringField { customLabel = "customer" } } },
                    { "department", r => r.@department = new [] { new SearchColumnStringField { customLabel = "department" } } },
                    { "departmentnohierarchy", r => r.@departmentnohierarchy = new [] { new SearchColumnStringField { customLabel = "departmentnohierarchy" } } },
                    { "global", r => r.@global = new [] { new SearchColumnBooleanField { customLabel = "global" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "item", r => r.@item = new [] { new SearchColumnStringField { customLabel = "item" } } },
                    { "location", r => r.@location = new [] { new SearchColumnStringField { customLabel = "location" } } },
                    { "locationnohierarchy", r => r.@locationnohierarchy = new [] { new SearchColumnStringField { customLabel = "locationnohierarchy" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnStringField { customLabel = "subsidiary" } } },
                    { "subsidiarynohierarchy", r => r.@subsidiarynohierarchy = new [] { new SearchColumnStringField { customLabel = "subsidiarynohierarchy" } } },
                    { "year", r => r.@year = new [] { new SearchColumnStringField { customLabel = "year" } } },
                    { "year2", r => r.@year2 = new [] { new SearchColumnStringField { customLabel = "year2" } } },
                };
            }
        }
    }
}