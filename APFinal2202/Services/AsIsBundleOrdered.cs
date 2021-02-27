using System.Collections.Generic;
using System.Web.Optimization;

namespace APFinal2202.Services
{
    public class AsIsBundleOrdered : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files) => files;
    }
}