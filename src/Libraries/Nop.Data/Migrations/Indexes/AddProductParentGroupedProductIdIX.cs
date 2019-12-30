﻿using FluentMigrator;
using Nop.Core.Domain.Catalog;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.Indexes
{
    [Migration(637123449689037705)]
    public class AddProductParentGroupedProductIdIX : AutoReversingMigration
    {
        #region Methods         

        public override void Up()
        {
            this.AddIndex("IX_Product_ParentGroupedProductId", nameof(Product), i => i.Ascending(),
                nameof(Product.ParentGroupedProductId));
        }

        #endregion
    }
}