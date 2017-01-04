using System;
using System.Collections.Generic;

using Nop.Core;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;

namespace DS.Core.Domain.Sellers
{
    /// <summary>
    /// Represents a Seller
    /// </summary>
    public partial class Seller : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Seller Guid
        /// </summary>
        public Guid SellerGuid { get; set; }
        
        #region Navigation properties
        
        public virtual Customer Customer { get; set; }
        #endregion
    }
}