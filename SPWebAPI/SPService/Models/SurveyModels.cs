using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;

namespace SPService.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }

        [Required]
        public string SurveyName { get; set; }

        [Required]
        public List<SurveyQuestion> SurveyQuestions { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

    }

    public class SurveyQuestion
    {
        public int SurveyQuestionId { get; set; }

        public int SurveyId { get; set; }

        [Required]
        public string SurveyQuestionText { get; set; }

        [Required]
        public List<SurveyOption> SurveyOptions { get; set; }

        [Required]
        public QuestionType QuestionTypeId { get; set; }

        [ForeignKey("SurveyId")]
        public Survey Survey { get; set; }
    }

    public enum QuestionType
    {
        SingleSelection,
        MultipleSelection,
        Rating5,
        Rating10
    }

    public class SurveyOption
    {
        public int SurveyOptionId { get; set; }

        public int SurveyQuestionId { get; set; }

        [ForeignKey("SurveyQuestionId")]
        public SurveyQuestion SurveyQuestion { get; set; }

        [Required]
        public string SurveyOptionText { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    //person who surveys are mailed and are expected to respond
    public class Respondent
    {
        [Required]
        public int RespondentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string RespondentEmail { get; set; }     
    }

    public class SurveyResponse
    {
        public int SurveyResponseId { get; set; }

        [ForeignKey("SurveyId")]
        public Survey Survey { get; set; }

        public int SurveyId { get; set; }
        
        public Respondent Respondent { get; set; }

        public List<SurveyResponseOptoion> SurveyResponseOptions { get; set; } 
    }

    public class SurveyResponseOptoion
    {
        public int SurveyResponseOptoionId { get; set; }

        public int SurveyOptionId { get; set; }

        [ForeignKey("SurveyOptionId")]
        public SurveyOption SurveyOption { get; set; }
    }
}