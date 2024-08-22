# KANANG MGA FORM KADA BUTTON DIHA NINYU IBUTANG ANG MGA COMPONENT O SULOD SA PAGE NA BELONG SA BUTTON












https://www.cnet.com/tech/tech-industry/25-technologies-that-have-changed-the-world/#google_vignette



CREATE PROCEDURE UpdateStudentLevels
AS
BEGIN
    DECLARE @i INT = 1;
    DECLARE @total INT;
    DECLARE @student_age INT;
    DECLARE @student_level VARCHAR(10);

    -- Get the total number of rows
    SELECT @total = COUNT(*) FROM Records;

    WHILE @i <= @total
    BEGIN
        -- Fetch the age of the current row
        SELECT @student_age = age FROM Records WHERE id = @i;

        -- Determine the level based on the age
        IF @student_age BETWEEN 14 AND 16
            SET @student_level = 'Freshman';
        ELSE IF @student_age BETWEEN 17 AND 19
            SET @student_level = 'Sophomore';
        ELSE IF @student_age BETWEEN 20 AND 22
            SET @student_level = 'Junior';
        ELSE IF @student_age BETWEEN 23 AND 25
            SET @student_level = 'Senior';
        ELSE
            SET @student_level = 'Unknown';

        -- Update the record with the new level
        UPDATE Records
        SET level = @student_level
        WHERE id = @i;

        -- Increment the loop counter
        SET @i = @i + 1;
    END;

    -- Display the updated data using IF-ELSE statement to set levels to lowercase
    PRINT 'Sample Output for IF-ELSE statement:'
    SELECT 
        'Id: ' + CAST(id AS VARCHAR) + ' | Name: ' + name + ' | Age: ' + CAST(age AS VARCHAR) + ' | Gender: ' + gender + ' | Level: ' +
        LOWER(level) AS Result
    FROM Records;

    -- Display the updated data using CASE statement to set levels to uppercase
    PRINT 'Sample Output for CASE statement:'
    SELECT 
        'Id: ' + CAST(id AS VARCHAR) + ' | Name: ' + name + ' | Age: ' + CAST(age AS VARCHAR) + ' | Gender: ' + gender + ' | Level: ' +
        UPPER(level) AS Result
    FROM Records;

END;

