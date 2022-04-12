Feature: Automation Practice site

@mytag
Scenario: Add the cheapest 'Printed Summer Dress' to cart and confirm it at the checkout
	Given I navigate to the Automation Practice website
	Then I confirm the page title is My Store
	Given I search for Printed Summer Dress
	Then I confirm the search finds 3 products
	Given I sort the products by Price: Lowest first
	When I press the quick view link for the first item
	Then I confirm the selected product is Printed Chiffon Dress
	Given I enter 2 as the quantity
	Given I set the size to M
	Given I select the colour Green
	Then I confirm the selected colour is Green
	Given I press the Add to cart button
	Then I confirm Printed Chiffon Dress has been added to the cart
	Given I press the Proceed to checkout button
	Then I confirm the total is $34.80
	Given I save a screenshot
	
	@mytag
Scenario: Send some feedback via the Contact us form
	Given I navigate to the Automation Practice website
	Then I confirm the page title is My Store
	Given I navigate to the Contact us page
	Then I confirm the page title is Contact us - My Store
	Given I choose Customer service as the subject heading
	Given I enter test@test.com as the email address
	Given I enter REF5556665 as the order number
	Given I enter Testing Testing Testing 1,2,3 as the message
	Given I press the Send button
	Then I confirm the message has been sent
	Given I save a screenshot