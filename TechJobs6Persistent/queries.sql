﻿-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
        -- Id (int)
        -- Name (varchar)
        -- EmployerId (int)
        
--Part 2: Write a query to list the names of the employers in St. Louis City.
        -- SELECT employers.name
        -- FROM employers
        -- WHERE employers.location = "St. Louis City";

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.
        -- SELECT skills.SkillName, skills.Id, jobskill.JobsId, jobskill.SkillsId
        -- FROM skills
        -- INNER JOIN jobskill ON skills.Id = jobskill.SkillsId
        -- WHERE skills.SkillName IS NOT NULL;
        -- ORDER BY skills.SkillName ASC;