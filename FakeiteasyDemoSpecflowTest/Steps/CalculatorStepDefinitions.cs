using TechTalk.SpecFlow;
using fakeiteasydemo;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using Google.Protobuf;

namespace FakeiteasyDemoSpecflowTest.Steps
{
    [Binding]
    public sealed class CalculationStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        Maths app = new Maths();
        double output, input1, input2, input3;
        int input4;
        [Given(@"I have provided (.*) and (.*) as the inputs")]
        public void GivenIHaveProvidedAndAsTheInputs(double p0, double p1, double p2, int p4)
        {
            input1 = p0;
            input2 = p1;
            input3 = p2;
            input4 = p4;
        }

        [Given(@"I have provided (.*) as input")]
        public void GivenIHaveProvidedAsInput(int p0)
        {
            input1 = p0;
        }

        [When(@"I press Addition")]
        public void WhenIPressAdd()
        {
            output = app.Add(input1, input2);
        }

        [When(@"I press Substract")]
        public void WhenIPressSubstract()
        {
            output = app.Substract(input1, input2);
        }

        [When(@"I press Multiply")]
        public void WhenIPressMultiply()
        {
            output = app.Multiply(input1, input2, input3);
        }

        [When(@"I press Divide")]
        public void WhenIPressDivide()
        {
            output = app.Divide(input1, input4);
        }

        [When(@"I press Multiply2No")]
        public void WhenIPressMultiply2No()
        {
            output = app.Multiply2No(input1, input2);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.AreEqual(p0, output);
        }
    }
}
