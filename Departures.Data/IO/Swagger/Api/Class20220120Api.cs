using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass20220120Api
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoardWithDetails</returns>
        StationBoardWithDetails GetArrBoardWithDetails(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoardWithDetails</returns>
        StationBoardWithDetails GetArrDepBoardWithDetails(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoard</returns>
        StationBoard GetArrivalBoard(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoard</returns>
        StationBoard GetArrivalDepartureBoard(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoardWithDetails</returns>
        StationBoardWithDetails GetDepBoardWithDetails(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoard</returns>
        StationBoard GetDepartureBoard(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoard</returns>
        DeparturesBoard GetFastestDepartures(string crs, string filterList, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoardWithDetails</returns>
        DeparturesBoardWithDetails GetFastestDeparturesWithDetails(string crs, string filterList, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoard</returns>
        DeparturesBoard GetNextDepartures(string crs, string filterList, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoardWithDetails</returns>
        DeparturesBoardWithDetails GetNextDeparturesWithDetails(string crs, string filterList, int? timeOffset, int? timeWindow);

        /// <summary>
        ///
        /// </summary>
        /// <param name="serviceid"></param>
        /// <returns>ServiceDetails</returns>
        ServiceDetails GetServiceDetails(string serviceid);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Class20220120Api : IClass20220120Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Class20220120Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Class20220120Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Class20220120Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Class20220120Api(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoardWithDetails</returns>
        public StationBoardWithDetails GetArrBoardWithDetails(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetArrBoardWithDetails");

            var path = "/api/20220120/GetArrBoardWithDetails/{crs}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (numRows != null) queryParams.Add("numRows", ApiClient.ParameterToString(numRows)); // query parameter
            if (filterCrs != null) queryParams.Add("filterCrs", ApiClient.ParameterToString(filterCrs)); // query parameter
            if (filterType != null) queryParams.Add("filterType", ApiClient.ParameterToString(filterType)); // query parameter
            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrBoardWithDetails: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrBoardWithDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (StationBoardWithDetails) ApiClient.Deserialize(response.Content, typeof(StationBoardWithDetails), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoardWithDetails</returns>
        public StationBoardWithDetails GetArrDepBoardWithDetails(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetArrDepBoardWithDetails");

            var path = "/api/20220120/GetArrDepBoardWithDetails/{crs}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (numRows != null) queryParams.Add("numRows", ApiClient.ParameterToString(numRows)); // query parameter
            if (filterCrs != null) queryParams.Add("filterCrs", ApiClient.ParameterToString(filterCrs)); // query parameter
            if (filterType != null) queryParams.Add("filterType", ApiClient.ParameterToString(filterType)); // query parameter
            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrDepBoardWithDetails: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrDepBoardWithDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (StationBoardWithDetails) ApiClient.Deserialize(response.Content, typeof(StationBoardWithDetails), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoard</returns>
        public StationBoard GetArrivalBoard(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetArrivalBoard");

            var path = "/api/20220120/GetArrivalBoard/{crs}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (numRows != null) queryParams.Add("numRows", ApiClient.ParameterToString(numRows)); // query parameter
            if (filterCrs != null) queryParams.Add("filterCrs", ApiClient.ParameterToString(filterCrs)); // query parameter
            if (filterType != null) queryParams.Add("filterType", ApiClient.ParameterToString(filterType)); // query parameter
            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrivalBoard: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrivalBoard: " + response.ErrorMessage, response.ErrorMessage);

            return (StationBoard) ApiClient.Deserialize(response.Content, typeof(StationBoard), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoard</returns>
        public StationBoard GetArrivalDepartureBoard(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetArrivalDepartureBoard");

            var path = "/api/20220120/GetArrivalDepartureBoard/{crs}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (numRows != null) queryParams.Add("numRows", ApiClient.ParameterToString(numRows)); // query parameter
            if (filterCrs != null) queryParams.Add("filterCrs", ApiClient.ParameterToString(filterCrs)); // query parameter
            if (filterType != null) queryParams.Add("filterType", ApiClient.ParameterToString(filterType)); // query parameter
            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrivalDepartureBoard: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetArrivalDepartureBoard: " + response.ErrorMessage, response.ErrorMessage);

            return (StationBoard) ApiClient.Deserialize(response.Content, typeof(StationBoard), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoardWithDetails</returns>
        public StationBoardWithDetails GetDepBoardWithDetails(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetDepBoardWithDetails");

            var path = "/api/20220120/GetDepBoardWithDetails/{crs}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (numRows != null) queryParams.Add("numRows", ApiClient.ParameterToString(numRows)); // query parameter
            if (filterCrs != null) queryParams.Add("filterCrs", ApiClient.ParameterToString(filterCrs)); // query parameter
            if (filterType != null) queryParams.Add("filterType", ApiClient.ParameterToString(filterType)); // query parameter
            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetDepBoardWithDetails: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetDepBoardWithDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (StationBoardWithDetails) ApiClient.Deserialize(response.Content, typeof(StationBoardWithDetails), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="numRows"></param>
        /// <param name="filterCrs"></param>
        /// <param name="filterType"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>StationBoard</returns>
        public StationBoard GetDepartureBoard(string crs, int? numRows, string filterCrs, string filterType, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetDepartureBoard");

            var path = "/api/20220120/GetDepartureBoard/{crs}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (numRows != null) queryParams.Add("numRows", ApiClient.ParameterToString(numRows)); // query parameter
            if (filterCrs != null) queryParams.Add("filterCrs", ApiClient.ParameterToString(filterCrs)); // query parameter
            if (filterType != null) queryParams.Add("filterType", ApiClient.ParameterToString(filterType)); // query parameter
            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetDepartureBoard: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetDepartureBoard: " + response.ErrorMessage, response.ErrorMessage);

            return (StationBoard) ApiClient.Deserialize(response.Content, typeof(StationBoard), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoard</returns>
        public DeparturesBoard GetFastestDepartures(string crs, string filterList, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetFastestDepartures");

            // verify the required parameter 'filterList' is set
            if (filterList == null) throw new ApiException(400, "Missing required parameter 'filterList' when calling GetFastestDepartures");

            var path = "/api/20220120/GetFastestDepartures/{crs}/{filterList}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));
            path = path.Replace("{" + "filterList" + "}", ApiClient.ParameterToString(filterList));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetFastestDepartures: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetFastestDepartures: " + response.ErrorMessage, response.ErrorMessage);

            return (DeparturesBoard) ApiClient.Deserialize(response.Content, typeof(DeparturesBoard), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoardWithDetails</returns>
        public DeparturesBoardWithDetails GetFastestDeparturesWithDetails(string crs, string filterList, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetFastestDeparturesWithDetails");

            // verify the required parameter 'filterList' is set
            if (filterList == null) throw new ApiException(400, "Missing required parameter 'filterList' when calling GetFastestDeparturesWithDetails");

            var path = "/api/20220120/GetFastestDeparturesWithDetails/{crs}/{filterList}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));
            path = path.Replace("{" + "filterList" + "}", ApiClient.ParameterToString(filterList));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetFastestDeparturesWithDetails: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetFastestDeparturesWithDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (DeparturesBoardWithDetails) ApiClient.Deserialize(response.Content, typeof(DeparturesBoardWithDetails), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoard</returns>
        public DeparturesBoard GetNextDepartures(string crs, string filterList, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetNextDepartures");

            // verify the required parameter 'filterList' is set
            if (filterList == null) throw new ApiException(400, "Missing required parameter 'filterList' when calling GetNextDepartures");

            var path = "/api/20220120/GetNextDepartures/{crs}/{filterList}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));
            path = path.Replace("{" + "filterList" + "}", ApiClient.ParameterToString(filterList));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetNextDepartures: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetNextDepartures: " + response.ErrorMessage, response.ErrorMessage);

            return (DeparturesBoard) ApiClient.Deserialize(response.Content, typeof(DeparturesBoard), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="crs"></param>
        /// <param name="filterList"></param>
        /// <param name="timeOffset"></param>
        /// <param name="timeWindow"></param>
        /// <returns>DeparturesBoardWithDetails</returns>
        public DeparturesBoardWithDetails GetNextDeparturesWithDetails(string crs, string filterList, int? timeOffset, int? timeWindow)
        {
            // verify the required parameter 'crs' is set
            if (crs == null) throw new ApiException(400, "Missing required parameter 'crs' when calling GetNextDeparturesWithDetails");

            // verify the required parameter 'filterList' is set
            if (filterList == null) throw new ApiException(400, "Missing required parameter 'filterList' when calling GetNextDeparturesWithDetails");

            var path = "/api/20220120/GetNextDeparturesWithDetails/{crs}/{filterList}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "crs" + "}", ApiClient.ParameterToString(crs));
            path = path.Replace("{" + "filterList" + "}", ApiClient.ParameterToString(filterList));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timeOffset != null) queryParams.Add("timeOffset", ApiClient.ParameterToString(timeOffset)); // query parameter
            if (timeWindow != null) queryParams.Add("timeWindow", ApiClient.ParameterToString(timeWindow)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetNextDeparturesWithDetails: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetNextDeparturesWithDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (DeparturesBoardWithDetails) ApiClient.Deserialize(response.Content, typeof(DeparturesBoardWithDetails), response.Headers.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="serviceid"></param>
        /// <returns>ServiceDetails</returns>
        public ServiceDetails GetServiceDetails(string serviceid)
        {
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling GetServiceDetails");

            var path = "/api/20220120/GetServiceDetails/{serviceid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceid" + "}", ApiClient.ParameterToString(serviceid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int) response.StatusCode) >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetServiceDetails: " + response.Content, response.Content);
            else if (((int) response.StatusCode) == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetServiceDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (ServiceDetails) ApiClient.Deserialize(response.Content, typeof(ServiceDetails), response.Headers.ToList());
        }
    }
}
