using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.ClinicalTrials.APITests
{
    public class Dates
    {
        public string Acronym { get; set; }
        public int SiteTarget { get; set; }
        public int Participants { get; set; }
        public object Maintainers { get; set; }
        public string LastMaintainedBy { get; set; }
        public string LastMaintainedDate { get; set; }
        public object Status { get; set; }
        public string HRECApprovalDate { get; set; }
        public string SiteHRECApprovalDate { get; set; }
        public bool RGONotApplicable { get; set; }
        public string RGOSubmissionDate { get; set; }
        public string RGOApprovalDate { get; set; }
        public string RecruitmentOpenDate { get; set; }
        public string FirstPatientDate { get; set; }
        public string RecruitmentClosedDate { get; set; }
        public string FollowUpCompleteDate { get; set; }
        public string StudyClosureDate { get; set; }
        public string SuspendedDate { get; set; }
        public string AbandonedDate { get; set; }
        public string ExtendedSubmissionDueDate { get; set; }
        public string ReportPeriodEndDate { get; set; }
        public bool CanArchive { get; set; }
        public bool CanRemove { get; set; }
        public int Percentage { get; set; }
        public string CreatedOn { get; set; }
        public string PerformanceFundingPaymentStartDate { get; set; }
        public int TargetRecruitmentType { get; set; }
        public int TargetRecruitmentTimePeriod { get; set; }
        public object TargetRecruitmentMinRange { get; set; }
        public object TargetRecruitmentMaxRange { get; set; }
    }

    public class CTUEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Details
    {
        public string Investigator { get; set; }
        public string KeyContact { get; set; }
        public CTUEmployee CTUEmployee { get; set; }
    }

    public class SiteResponsibilityLookupItem
    {
        public int SiteResponsibilityLookupItemId { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int CheckedValue { get; set; }
        public int DisplayOrder { get; set; }
    }

    public class OtherCTU
    {
        public string Value { get; set; }
        public string Selected { get; set; }
        public string Disabled { get; set; }
        public string Text { get; set; }
    }

    public class CurrentPeriod
    {
        public object ReportingPeriod { get; set; }
        public int ReportingPeriodId { get; set; }
        public object Prescreened { get; set; }
        public object ScreenFailures { get; set; }
        public object NewEnrollments { get; set; }
        public object ActiveOnIntervention { get; set; }
        public object CompletedIntervention { get; set; }
        public object FollowUp { get; set; }
        public object Discontinued { get; set; }
        public object ReportPeriodBeginDate { get; set; }
        public object ReportPeriodEndDate { get; set; }
    }

    public class Cumulative
    {
        public object ReportingPeriod { get; set; }
        public int ReportingPeriodId { get; set; }
        public object ReportPeriodBeginDate { get; set; }
        public object ReportPeriodEndDate { get; set; }
    }

    public class Historical
    {
        public string ReportingPeriod { get; set; }
        public int ReportingPeriodId { get; set; }
        public int Prescreened { get; set; }
        public int ScreenFailures { get; set; }
        public int NewEnrollments { get; set; }
        public int ActiveOnIntervention { get; set; }
        public int CompletedIntervention { get; set; }
        public int FollowUp { get; set; }
        public int Discontinued { get; set; }
        public string ReportPeriodBeginDate { get; set; }
        public string ReportPeriodEndDate { get; set; }
    }

    public class PriorActivity
    {
        public object ReportingPeriod { get; set; }
        public int ReportingPeriodId { get; set; }
        public object Prescreened { get; set; }
        public object ScreenFailures { get; set; }
        public object NewEnrollments { get; set; }
        public object ActiveOnIntervention { get; set; }
        public object CompletedIntervention { get; set; }
        public object FollowUp { get; set; }
        public object Discontinued { get; set; }
        public object ReportPeriodBeginDate { get; set; }
        public object ReportPeriodEndDate { get; set; }
    }

    public class Activity
    {
        public int CurrentCTUId { get; set; }
        public List<SiteResponsibilityLookupItem> SiteResponsibilityLookupItems { get; set; }
        public int SiteResponsibilityLookupItemId { get; set; }
        public List<OtherCTU> OtherCTUs { get; set; }
        public List<object> SelectedOtherCTUs { get; set; }
        public object FollowUpPatients { get; set; }
        public CurrentPeriod CurrentPeriod { get; set; }
        public Cumulative Cumulative { get; set; }
        public List<Historical> Historical { get; set; }
        public PriorActivity PriorActivity { get; set; }
        public string BeginsOnDate { get; set; }
        public string EndsOnDate { get; set; }
    }

    public class CTUEmployee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SiteTargetTimePeriodLookup
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class SiteTargetTypeLookup
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class Disable
    {
        public bool SiteHRECApprovalDate { get; set; }
        public bool RGOSubmissionDate { get; set; }
        public bool RGOApprovalDate { get; set; }
        public bool RecruitmentOpenDate { get; set; }
        public bool FirstPatientDate { get; set; }
        public bool SiteTarget { get; set; }
    }

    public class Tooltip
    {
        public string HRECApproval { get; set; }
        public string SiteHRECApproval { get; set; }
        public string SiteTarget { get; set; }
        public string RGOSubmission { get; set; }
        public string RGOAuthorisation { get; set; }
        public string RecruitmentOpen { get; set; }
        public string FirstPatientOnTrial { get; set; }
        public string RecruitmentClosed { get; set; }
        public string FollowUpComplete { get; set; }
        public string StudyClosure { get; set; }
        public string PreScreened { get; set; }
        public string Participants { get; set; }
        public string ScreenFailures { get; set; }
        public string NewEnrolments { get; set; }
        public string ActiveOnIntervention { get; set; }
        public string CompletedIntervention { get; set; }
        public string FollowUp { get; set; }
        public string Discontinued { get; set; }
        public string TrialSuspend { get; set; }
        public string TrialAbandoned { get; set; }
        public string RGONotApplicable { get; set; }
    }

    public class UI
    {
        public bool IsAbandoned { get; set; }
        public bool IsSuspended { get; set; }
        public bool CanAbandon { get; set; }
        public bool CanSuspend { get; set; }
        public int CTUEmployeeId { get; set; }
        public int IsAdmin { get; set; }
        public Disable Disable { get; set; }
        public Tooltip Tooltip { get; set; }
    }

    public class RootObject
    {
        public int Id { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSignedOff { get; set; }
        public bool IsArchived { get; set; }
        public Dates Dates { get; set; }
        public Details Details { get; set; }
        public Activity Activity { get; set; }
        public List<CTUEmployee2> CTUEmployees { get; set; }
        public List<object> ValidationErrors { get; set; }
        public List<SiteTargetTimePeriodLookup> SiteTargetTimePeriodLookups { get; set; }
        public List<SiteTargetTypeLookup> SiteTargetTypeLookups { get; set; }
        public bool IsIncludeCurrentPeriodData { get; set; }
        public UI UI { get; set; }
    }
}
