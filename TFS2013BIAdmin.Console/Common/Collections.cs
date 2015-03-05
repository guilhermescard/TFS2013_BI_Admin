using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFS2013BIAdmin.Console
{
    public class Collections
    {
        public static List<string> GetTeamProjectCollections(string _uri)
        {
            List<string> _collections = new List<string>();
            
            TfsConfigurationServer configServer = TfsConfigurationServerFactory.GetConfigurationServer(new Uri(_uri));
            ReadOnlyCollection<CatalogNode> collectionNodes = configServer.CatalogNode.QueryChildren(
                new[] { CatalogResourceTypes.ProjectCollection },
                false, CatalogQueryOptions.None);

            foreach (CatalogNode collectionNode in collectionNodes)
            {
                Guid collectionId = new Guid(collectionNode.Resource.Properties["InstanceId"]);
                TfsTeamProjectCollection teamProjectCollection = configServer.GetTeamProjectCollection(collectionId);

                _collections.Add(teamProjectCollection.CatalogNode.Resource.DisplayName);

            }

            return _collections;
        }

        public static List<string> GetTeamProjects(string _uri)
        {
            List<string> _teamProjects = new List<string>();

            TfsConfigurationServer configServer = TfsConfigurationServerFactory.GetConfigurationServer(new Uri(_uri));
            ReadOnlyCollection<CatalogNode> collectionNodes = configServer.CatalogNode.QueryChildren(
                new[] { CatalogResourceTypes.ProjectCollection },
                false, CatalogQueryOptions.None);

            foreach (CatalogNode collectionNode in collectionNodes)
            {
                Guid collectionId = new Guid(collectionNode.Resource.Properties["InstanceId"]);
                TfsTeamProjectCollection teamProjectCollection = configServer.GetTeamProjectCollection(collectionId);

                ReadOnlyCollection<CatalogNode> projectNodes = collectionNode.QueryChildren(
                new[] { CatalogResourceTypes.TeamProject },
                false, CatalogQueryOptions.None);

                foreach (CatalogNode projectNode in projectNodes)
                {
                    _teamProjects.Add(projectNode.Resource.DisplayName);
                }

            }

            return _teamProjects;
        } 
    }
}
