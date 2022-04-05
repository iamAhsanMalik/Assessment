using System;
using System.Collections.Generic;
using System.Linq;

public class Assessment : IAssessment
{
    /// <summary>
    /// Returns the score with the highest value
    /// </summary>
    public Score? WithMax(IEnumerable<Score> scores)
    {
        return scores.Max();
    }

    /// <summary>
    /// Returns the average value of the collection. For an empty collection it returns null
    /// </summary>
    public double? GetAverageOrDefault(IEnumerable<int> items)
    {
        if (items.Any())
        {
            return items.Average();
        }
        else
        {
            return null;
        }
    }


    /// <summary>
    /// Appends the suffix value to the text if the text has value. If not, it returns empty.
    /// </summary>
    public string WithSuffix(string text, string suffixValue)
    {
        try
        {
            if (!string.IsNullOrEmpty(text))
            {
                return String.Join(suffixValue, text);
            }
            else
            {
                return "";
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        //throw new NotImplementedException();
    }

    /// <summary>
    /// It fetches all the data from the source.
    /// </summary>
    /// <param name="source">The source data provider returns items by page. NextPageToken is the page token of the next page. If there are no more items to return, nextPageToken will be empty. Passing a null or empty string to the provider will return the first page of the data.
    /// If no value is specified for nextPageToken, the provider will return the first page.
    /// </param>
    /// <returns></returns>
    public IEnumerable<Score> GetAllScoresFrom(IDataProvider<Score> source)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns child's name prefixed with all its parents' names separated by the specified separator.Example : Parent/Child
    /// </summary>
    public string GetFullName(IHierarchy child, string separator = null)
    {
        separator ??= "/";
        string Parent = Convert.ToString(child.Parent);
        char[] separators = new char[] { '/' };

        string[] subs = Parent.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        /// ...
        throw new NotImplementedException();
    }

    /// <summary>
    /// Refactor: Returns the value that is closest to the average value of the specified numbers.
    /// </summary>
    public int? ClosestToAverageOrDefault(IEnumerable<int> numbers)
    {
        return Convert.ToInt32(numbers.Average());
    }

    /// <summary>
    /// Returns date ranges that have similar bookings on each day in the range.
    /// Read the example carefully.
    /// Example : [{Project:HR, Date: 01/02/2020 , Allocation: 10},
    ///            {Project:CRM, Date: 01/02/2020 , Allocation: 15},
    ///            {Project:HR, Date: 02/02/2020 , Allocation: 10},
    ///            {Project:CRM, Date: 02/02/2020 , Allocation: 15},
    ///            {Project:HR, Date: 03/02/2020 , Allocation: 15},
    ///            {Project:CRM, Date: 03/02/2020 , Allocation: 15},
    ///            {Project:HR, Date: 04/02/2020 , Allocation: 15},
    ///            {Project:CRM, Date: 04/02/2020 , Allocation: 15},
    ///            {Project:HR, Date: 05/02/2020 , Allocation: 15},
    ///            {Project:CRM, Date: 05/02/2020 , Allocation: 15},
    ///            {Project:ECom, Date: 05/02/2020 , Allocation: 15},
    ///            {Project:ECom, Date: 06/02/2020 , Allocation: 10},
    ///            {Project:CRM, Date: 06/02/2020 , Allocation: 15}
    ///            {Project:ECom, Date: 07/02/2020 , Allocation: 10},
    ///            {Project:CRM, Date: 07/02/2020 , Allocation: 15}]    
    /// Returns : 
    ///          [
    ///            { From:01/02/2020 , To:02/02/2020 , [{ Project:CRM , Allocation:15 },{ Project:HR , Allocation:10 }]  },
    ///            { From:03/02/2020 , To:04/02/2020 , [{ Project:CRM , Allocation:15 },{ Project:HR , Allocation:15 }]  },
    ///            { From:05/02/2020 , To:05/02/2020 , [{ Project:CRM , Allocation:15 },{ Project:HR , Allocation:15 },{ Project:ECom , Allocation:15 }]  },
    ///            { From:06/02/2020 , To:07/02/2020 , [{ Project:CRM , Allocation:15 },{ Project:ECom , Allocation:10 }]  }
    ///          ]
    /// </summary>
    public IEnumerable<BookingGrouping> Group(IEnumerable<Booking> dates)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Merges the specified collections so that the n-th element of the second list should appear after the n-th element of the first collection. 
    /// Example : first : 1,3,5 second : 2,4,6 -> result : 1,2,3,4,5,6
    /// </summary>
    public IEnumerable<int> Merge(IEnumerable<int> first, IEnumerable<int> second)
    {
        try
        {
            return first.Concat(second).OrderBy(x => x);
        }
        catch (Exception ex)
        {
            throw new Exception($"Something Went Wrong {ex.Message}");
        }
    }
}
