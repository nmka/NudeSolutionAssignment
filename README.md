# NudeSolutionAssignment
- [x] Build/Run with Visual Studio 2019 or 2022, or the .NET CLI.

I builth it using Visual Studio 2022
- [x] Properly render in Chrome (latest version).

![nude](https://user-images.githubusercontent.com/1495713/231646429-9665254c-2625-4388-8fc1-838fc8ae0c23.png)
- [x] Allow a user to add an item with the following fields:
  o Name (text input).
  o Value (numeric input).
  o Category (dropdown list):

- done
- [ ] Adding/deleting/renaming of categories is not required.

- [x] This can be a static list of categories.

- I created initial dataseeder for category using migration
- [x] Allow a user to remove an item from the list.

- Done. I had two choise for creating endpoints. `/categories/1/items/3` or `/items/3` 
I chose unnested API endpoint because items have primary keys and so i don't need to provide category idea when i delete item.
Sometimes nested API endpoints makes sense in some situation but on this task i want things to be simple.

- [x] Display all items in a list, which is grouped and sorted by category.

- I queried categories with items as its property. So from api its comes like `categories.items`. This way makes sense for this task because requirement was to items to be grouped and sorted by category.

- [x] Display the summed value of all items belonging to a category.

- Did it in client side because it was easier to increase or decrease when we remove item or add item to category.
Other way would be getting it from backend and request everytime from backend after we add item or remove item to category. Which is not good.

- [x] Display the total summed value of all the items in the list.

i created CategoryValueSum reducer for category object and then using it to create TotalSummedValue reducer. DRY ;) 
- [x] Persist the data to a data store (SQL, NoSQL, LocalDB, anything is fine).

- Used localDB otherwise i have to setup docker for SQL server... I don't feel like it is important

- [x] Restore the data when the application is restarted.

- Done
