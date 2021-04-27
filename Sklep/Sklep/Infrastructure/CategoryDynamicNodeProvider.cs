using MvcSiteMapProvider;
using Sklep.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class CategoryDynamicNodeProvider : DynamicNodeProviderBase
    {
        FilmsContext db = new FilmsContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var categoryDN = new List<DynamicNode>();

            foreach (var category in db.Categories)
            {
                DynamicNode dn = new DynamicNode()
                {
                    Title = category.Name,
                    Key = "Category_" + category.CategoryId

                };

                dn.RouteValues.Add("categoryName", category.Name);
                categoryDN.Add(dn);
            }

            return categoryDN;
        }
    }
}