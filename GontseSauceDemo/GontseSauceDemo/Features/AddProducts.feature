Feature: AddProducts

A short summary of the feature

@tag1
Scenario: [Place Order]
	Given [User Is Logged On]
	When [User adds <"backpack"> to cart]
	And [User clicks on cart]
	Then [Cart Page Should be displayed]
	When [User clicks on checkout]
	Then [Checkout Information is Displayed]
	Then [User enters <"Gontse">, <"Taunyane">, <"0175">]
	When [User Clicks Continue]
	Then [Checkout Overview Page is Displayed]
	Then [User Clicks Finish]

	Scenario: [Add Multiple Products and Remove last one]
	Given [User Is Logged On]
	When [User adds <"backpack"> to cart]
	And [User adds <"bikelight"> to cart]
	And [User adds <"boltshirt"> to cart]
	And [User clicks on cart]
	Then [Cart Page Should be displayed]
	Then [User removes <"boltshirt">]
	When [User clicks on checkout]
	Then [Checkout Information is Displayed]
	Then [User enters <"Gontse">, <"Taunyane">, <"0175">]
	When [User Clicks Continue]
	Then [Checkout Overview Page is Displayed]
	Then [User Clicks Finish]



