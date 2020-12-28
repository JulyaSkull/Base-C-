Feature: Product create
	As a user
	I want to create new product

@mytag
Scenario: Product create
	Given I go and login to "http://localhost:5000/"
	When  I click on "All Products" button
	And I click on Create New button
	And I enter values of product, whitch want create "Spagetti", "Dairy Products", "Heli Süßwaren GmbH & Co. KG", "17", "3", "500", "6", "9"
	And I click on Submit button
	Then A product whitch name "Spagetti" should appear on the all product page