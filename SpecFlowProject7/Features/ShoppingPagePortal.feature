Feature: LoginPagePortal
        1.Order a Tshirt and veriify in Order History
		2. Update USer's First Name

@SmokeTest1
Scenario:Order a Tshirt from Shopping portal
	Given I have navigate to AutomationPractice Page
	      | URL                                      |
	      | http://automationpractice.com/index.php |
	And I see the Home Page of Portal Page fully loaded
	When I tap Sign In CTA as 
	Then I reach Sign In Page of Authentication Portal
	And I give username and passowrd in Sign Page
	    | username      | passowrd  |
	    | vinu@vinu.com | qwerty123 |
	And I tap SignIn CTA
	Then I reached to MyAccount Page
	And I tap on Tshirt section 
	And reached to Tshirt Page
	When I tap first Tshirt and Add the Add to Cart
	And I tap to Proceed to Checkout
	And I confirm the Proceed Checkout in payment page
	And I confirm the Proceed Checkout in address page
	And I check the terms and condition
	When I confirm the Proceed Checkout in shipping page
	And I select Pay by check
	And I confirm my order by tapping Confirm CTA
	And verify Order is placed and copy Order refrence
	When I view my Customer account
	Then I reached to MyAccount Page
	And I tap on Order History Details
	Then  I verify my order refrence in order history

	@SmokeTest2
Scenario:Update First name in Personal Information
	Given I have navigate to AutomationPractice Page
	| URL                                      |
	      | http://automationpractice.com/index.php |
	And I see the Home Page of Portal Page fully loaded
	When I tap Sign In CTA as 
	Then I reach Sign In Page of Authentication Portal
	And I give username and passowrd in Sign Page
	    | username      | passowrd  |
	    | vinu@vinu.com | qwerty123 |
	And I tap SignIn CTA
	Then I reached to MyAccount Page
	And I tap on My personal information
	Then  I edit my Firstname in  personal information
	| passowrd |
	| qwerty123|
	Then I see Personal information updated Successfully and I can see new Firstname
