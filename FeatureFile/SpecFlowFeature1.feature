Feature:Tide Web Application
      Automating the Given Web Application


Scenario: Tide Register
	Given Load the given Tide Website
	When you click on Register Button at top
	And Click on sign up button a new tab Should open
    And Enter FirstName,Email Adress,Password
    Then click on create account button and you are Regitered.

Scenario: Contact us
	Given Load the Website
	When we click on Contact us button contact page displays
	And we should click on How can i get tide coupons
	Then it should diplay the  page

Scenario:Live Chat
	Given Load the Website given
	When we Click on Live chat button
	And Click on ChatNow button
	Then it should take us to the support page

Scenario:Shop product by type pack
    Given Open the website
	When i move the cursor to shop products it should display products
	And click on Packs and its should show products
	And select product to buy and click on find retailers
	Then click the option Buy

Scenario: Language Change
    Given Open website
	When i click on Us-English bar at top page should open
	Then Click on suitable language and changes should be applied

Scenario: Search Validation
    Given open the given tide webpage
	When i click on search bar and type Tidepowder page should open
	And click on News and articles
	Then Page will open and Click on readmore

Scenario: Language Change to Us-Spanish
   Given open webpage
   When i click on Language bar at top
   Then click on Us-Spanish and changes should be done

Scenario: Language Change to Canada-French
    Given Open the webpage
	When i click language change bar at top
	Then click on Canada-French and change is done 

Scenario: Login
  Given Open the given webpage 
  When i click on  Register page should open
  And i should click on Signup
  And a new tab should open click on Login
  And Enter Email and password
  Then click on Login


