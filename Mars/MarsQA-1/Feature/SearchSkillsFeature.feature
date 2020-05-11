Feature: SearchSkillsFeature
	In order to Search Skills
	I want to search by catagories and subcatagories

@mytag
Scenario: Check if the user is able to click All Catagories link
	Given I Clicked Search Skills Icon 
	And I Clicked All Catagories Link
	Then user should be navigated to all catagories search results page


@mytag
Scenario Outline: Check if the user is able to Search Skills by Catagories
	Given I have clicked Search Skills Icon
	And I have Clicked on Catagory named  <SelectCatagory>
	Then the user should be able to navigated to the <SelectCatagory> <CatagoryUrl>

Examples: 
	| SelectCatagory        | CatagoryUrl        |
	| Digital Marketing     | DigitalMarketing   |
	| Graphics & Design     | GraphicsDesign     |
	| Programming & Tech    | ProgrammingTech    |
	| Writing & Translation | WritingTranslation |
	| Video & Animation     | VideoAnimation     |
	| Music & Audio         | MusicAudio         |
	| Fun & Lifestyle       | FunLifestyle       |
	| Business              | Business           |


@mytag
Scenario Outline: Check if the user is able to Seach Programming & Tech SubCatagories
	Given I have clicked the Search Skills Icon
	And I Clicked on Programming & Tech Catagory 
	And I Clicked on SubCatagory <SelectSubCatagory> 
	Then user should be navigated to Subcatagory page <SelectSubCatagory> <SubCatagoryURL>

Examples: 
	 | SelectSubCatagory       | SubCatagoryURL |
	 | WordPress               | subcat=1       |
	 | Web & Mobile App        | subcat=2       |
	 | Data Analysis & Reports | subcat=3       |
	 | QA                      | subcat=4       |
	

@mytag
Scenario Outline: Check if the user is able to Search all Graphics & Design SubCatagories
	Given I have clicked on the Search Skills Icon
	And I Clicked on Graphics & Design Catagory 
	And I Clicked on the GraphicsDesignSubCatagory <GraphicsDesignSubCatagory > 
	Then user should be navigated to GraphicsDesignSubcatagory page <GraphicsDesignSubCatagory > <GraphicsDesignSubCatagoryUrl>

Examples: 
	 | GraphicsDesignSubCatagory  | GraphicsDesignSubCatagoryUrl |
	 | Logo Design                | 1                            |
	 | Book & Album covers        | 2                            |
	 | Flyers & Brochures         | 3                            |
	 | Web & Mobile Design        | 4                            |
	 | Search & Display Marketing | 5                            |


