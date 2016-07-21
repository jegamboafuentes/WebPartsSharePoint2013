# Manage Metadata (Taxonomy) With a Share Point web Part
It takes the Manage Metadata and populated the DropDown List, and then Create Taxonomy and set into a List
## Request:
Create a C# Visual Web Part that will act as a data entry form into a list.  The Web Part should contain multiple drop down lists that are dynamically populated with Term Groups, Term Sets, Terms within the Managed Metadata Term Store.  

1. Step 1.  Create the taxonomy within the Managed Metadata Term Store
- Create a taxonomy for Computer Products as follows:
Term Group:  Laptops
```
Term Sets:  HP, Dell, Toshiba, Lenovo
```
Terms:  Please populate terms for each term set with laptop models from the respective manufacture. **3 Models for each brand.**

2. Step 2.  Create the List.
- Create a Custom List within SharePoint called “Laptops”.
- Create two custom columns for the list, both of which should be of type “Managed Metadata”.

3. Create the Visual Web Part.

- The dropdown lists for the Term Groups, Term Sets, and Terms should be cascading.  If HP is chosen for the Term Set DropDownList, then only HP computers should show up in the subsequent DropDownList for the Terms.  
- You should have a total of 2 DropDownLists on the Web Part.  One to choose the Term Set and another to choose the term.



