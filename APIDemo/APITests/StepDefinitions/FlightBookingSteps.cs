using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APITests.StepDefinitions
{
    [Binding]
    public class FlightBookingSteps
    {
        private readonly ScenarioContext _scenarioContext;
        // private IRestResponse _response;

        private const string BASE_URL = "https://reqres.in/";
        public FlightBookingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given("I have the Skyscanner API endpoint")]
        public void GivenIHaveTheSkyscannerAPIEndpoint()
        {
            // Set up the Skyscanner API endpoint URL
            // Example:
            _scenarioContext["apiEndpoint"] = "https://www.skyscanner.net/api/bookflight";
        }

        [When("I send a POST request to book a return flight")]
        public void WhenISendAPOSTRequestToBookAReturnFlight()
        {
            // Implement sending a POST request using RestSharp to book a return flight
            // Example:
          //  var client = new RestClient(_scenarioContext["apiEndpoint"].ToString());
          //  var request = new RestRequest(Method.POST);
           // _response = client.Execute(request);
        }
        [Given("I have the SkyScanner API endpoint")]
        public void GivenIHaveTheSkyScannerAPIEndpoint()
        {
            // Set up your API endpoint URL here from Skyscanner
        }



        [Then("the response should have a status code of (\\d+)")]
        public void ThenTheResponseShouldHaveAStatusCodeOf(int expectedStatusCode)
        {
            // Check the response status code
        }

        [Then("the return flight should be booked successfully")]
        public void ThenTheReturnFlightShouldBeBookedSuccessfully()
        {
            // Implement verification logic for successful booking
        }
    }
}
