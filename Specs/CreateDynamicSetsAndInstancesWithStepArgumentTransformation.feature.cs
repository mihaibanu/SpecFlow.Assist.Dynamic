﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17626
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create dynamic sets and instance with step argument transformations")]
    public partial class CreateDynamicSetsAndInstanceWithStepArgumentTransformationsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateDynamicSetsAndInstancesWithStepArgumentTransformation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create dynamic sets and instance with step argument transformations", "In order to write super slick and easy code\r\nAs a SpecFlow step definition develo" +
                    "per\r\nI want to be able to define the types as argument to the step", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating dynamic set with the use of step argument transformation")]
        public virtual void CreatingDynamicSetWithTheUseOfStepArgumentTransformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating dynamic set with the use of step argument transformation", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table1.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table1.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
            table1.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table1.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 7
 testRunner.Given("I create a set of dynamic instances from this table using step argument transform" +
                    "ation", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table2.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table2.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
            table2.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table2.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 13
 testRunner.When("I compare the set to this table using step argument transformation", ((string)(null)), table2, "When ");
#line 19
 testRunner.Then("no set comparison exception should have been thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Matching a dynamic instance against a table")]
        public virtual void MatchingADynamicInstanceAgainstATable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Matching a dynamic instance against a table", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters",
                        "Is Developer"});
            table3.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96",
                        "true"});
#line 22
 testRunner.Given("I create a dynamic instance from this table using step argument transformation", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters",
                        "Is Developer"});
            table4.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96",
                        "true"});
#line 25
 testRunner.When("I compare it to this table using step argument transformation", ((string)(null)), table4, "When ");
#line 28
 testRunner.Then("no instance comparison exception should have been thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Test property with step argument transformation")]
        public virtual void TestPropertyWithStepArgumentTransformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test property with step argument transformation", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters",
                        "Is Developer"});
            table5.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96",
                        "true"});
#line 31
 testRunner.Given("I create a dynamic instance from this table using step argument transformation", ((string)(null)), table5, "Given ");
#line 34
 testRunner.Then("the Name property should equal \'Marcus\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("the IsDeveloper property should equal \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
