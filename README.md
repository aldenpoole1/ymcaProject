### <p align="center">***Class Project has finished, so VB development is done. Gutted program for project description and presentation. Continuing development in JavaScript and adding all functionality.***</p>

### <p align="center">Cherokee Outdoor YMCA Schedule Building Project</p>
<p align="center">Project for building camp schedules at the Y, doubles as final project for AppDev I</p>
<p>See project description under update feed.</p>
<hr />
<br>

* **UPDATED 3/22/18**

  - Added **campLocation** object for creating locations
  - Added **Main Window** form with buttons for opening the group creator, location creator, and (unfinsished) schedule creator
  - **Form1** changed to **GroupCreator**
  - Added new **GroupCreator** functions. Creates list of group objects for scheduling. Tests against location availability.
  - Added **LocationCreator** but it is not functional.
  
  **Unchanged:** 
  - **campGroup** class for camp group creation, set/gets, and get/display information methods
  
  **ON THE HORIZON**
  - Finishing **LocationCreator** class to mirror functionality of the **GroupCreator** class
  - Saving information to a database or .csv to enable editing of previous groups and locations
  - Create scheduling classes finishing scheduling functions
  
  
  
  **NOTE**
  I still haven't discovered how to relatively link sources in visual basic. For now, locations and groups will be stored in lists that will need to be repopulated in each instance of the program. Any text file editing is done locally and for my debugging purposes.
  
  
 **Project Case**
 
  The Cherokee Outdoor YMCA in Woodstock runs a summer camp that serves around 450 children per week on average. With a ratio of about twelve kids to one group, the camp operates up to thirty seven groups on 200 acres of property. Currently, they do not have any application or program to build schedules for each group. Instead, each group counselor creates their own schedule. This leads to schedule conflicts where there are too many children at one location or mismatched age groups such as 7th graders at a location playing alongside 1st graders. Over the years that I have observed this system, no solution has been suggested for this problem. My application will streamline the schedule making process and ensure no conflicts are created.

**Input:**

Users will be able to add locations with age and size limits as well as add groups with age ids, sizes, names, and counselor names.

Location variables include:

-	Maximum children allowed
-	Age restrictions
-	Location lists

Group variables include:

-	Group size
-	Group age
-	Group name
-	Counselor name
- Group lists

**Process:**

The application will compare these variables to ensure that the sums of group sizes won’t exceed locations’ maximum sizes, that the group age doesn’t conflict with any age restrictions, and that groups of widely varying ages will not be at the same location at the same time.

**Output:**

The application will output a master schedule and schedule for each group, both in excel spreadsheet form.


  
