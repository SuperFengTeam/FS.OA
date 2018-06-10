using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.OA.Common
{
    public class ConstHelper
    {
        #region sql名

        public class SqlName
        {

            public const string HT_RC_TALENTINFO_SELECT_001 = "HT_RC_TalentInfo_Select_001.sql";
            /// <summary>
            /// 推荐自荐一览查询grid-李兰夫-170309
            /// </summary>
            public const string HT_RC_RECRUITADINFO_SELECT_001 = "HT_RC_RecruitADInfo_Select_001.sql";

            public const string RECOMMENDINFOLIST_SELECT_001 = "RecommendInfoList_Select_001.sql";

            public const string HT_RC_REQUESTRECOMMENDINFO_SELECT_002 = "HT_RC_RequestRecommendInfo_Select_002.sql";

            public const string HT_RC_TALENTINFO_SELECT_002 = "HT_RC_TalentInfo_Select_002.sql";
            /// <summary>
            /// 面试结果录入-李兰夫-170313
            /// </summary>
            public const string INTERVIEWRESULT_SELECT_001 = "InterviewResult_Select_001.sql";

            public const string HT_RC_RECRUITREQUESTINFO_SELECT_001 = "HT_RC_RecruitRequestInfo_Select_001.sql";

            public const string HT_RC_RECRUITREQUESTINFO_SELECT_002 = "HT_RC_RecruitRequestInfo_Select_002.sql";

            public const string HT_RC_RECRUITREQUESTINFO_SELECT_003 = "HT_RC_RecruitRequestInfo_Select_003.sql";

            public const string HT_RC_RECRUITREQUESTINFO_SELECT_004 = "HT_RC_RecruitRequestInfo_Select_004.sql";

            public const string RECRUITMENTPERSONNELINFO_SELECT_001 = "RecruitmentPersonnelInfo_Select_001.sql";
            /// <summary>
            /// 取得需要审核的面试人员信息-李兰夫17-03-13
            /// </summary>
            public const string INTERVIEWRESULTAUDIT_SELECT_001 = "InterviewResultAudit_Select_001.sql";
        }
        #endregion

        #region sql文

        public class SqlText
        {
            public const string DATETIME_NOW = "REPLACE(REPLACE(REPLACE(REPLACE(CONVERT(VARCHAR(100),GETDATE(),121),'-',''),' ',''),':',''),'.','')";

        }
        #endregion

        #region 处理ID定数
        ///<summary>
        ///处理ID定数.
        ///</summary>
        public class ConstID
        {
            /// <summary>
            /// 用户名
            /// </summary>
            public const string SESSION_USERCODE = "UserCode";
            public const string SESSION_USERID = "UserID";
            public const string SESSION_USERNAME = "UserName";
            public const string SESSION_SYSTEMID = "SystemId";
            public const string SESSION_ACCID = "AccId";

            public const string SESSION_SYSTEMMENU = "Menus";
            public const string SESSION_PAGES = "Pages";
            public const string SESSION_ACCS = "Accs";
            public const string SESSION_RoleS = "Roles";
            public const string SESSION_CONTROLS = "Controls";
            public const string SESSION_USER_ROLES = "UserRoles";

            public const string COOKIE_USERNAME = "UserName";
            public const string COOKIE_SYSTEMMENU = "Menus";

            public const string SYSTEMID = "XJJT.AuthorityCenter";

            public const string SESSION_AUTHORITY_SYSTEM = "AuthoritySystem";

            public const string SESSION_OA_SYSTEM = "OASystem";

            public const string CACHE_ACC = "Acc";
            public const string CACHE_SYSTEM = "System";
            public const string CACHE_APPROVAL_TYPE = "ApprovalType";
            public const string CACHE_AUTHORITY = "Authority";
            public const string CACHE_DELETEFLG = "DeleteFlg";
        }


        #endregion

        #region 码表ID.
        /// <summary>
        /// 码表ID.
        /// </summary>
        public class ExCodeMasterID
        {
            /// <summary>
            /// 申请类型
            /// </summary>
            public const string CApplyType = "ApplyType";
            /// <summary>
            /// 指标状态
            /// </summary>
            public const string CDelFlg = "DelFlg";
            /// <summary>
            /// 审批状态
            /// </summary>
            public const string CApplyState = "ApplyState";
            /// <summary>
            /// 档案类型
            /// </summary>
            public const string CArchivesType = "ArchivesType";
            /// <summary>
            /// 业务区分
            /// </summary>
            public const string CBussinessDivisionCode = "BussinessDivisionCode";
            /// <summary>
            /// 户籍物件类型
            /// </summary>
            public const string CCensusType = "CensusType";
            /// <summary>
            /// 证件类型
            /// </summary>
            public const string CCertificateType = "CertificateType";
            /// <summary>
            /// 确认状态
            /// </summary>
            public const string CConfirmState = "ConfirmState";
            /// <summary>
            /// 合同期限
            /// </summary>
            public const string CContractDeadineType = "ContractDeadineType";
            /// <summary>
            /// 合同状态
            /// </summary>
            public const string CContractState = "ContractState";
            /// <summary>
            /// 合同期限类型
            /// </summary>
            public const string CContracTermType = "ContracTermType";
            /// <summary>
            /// 证书类型
            /// </summary>
            public const string CCredentialsType = "CredentialsType";
            /// <summary>
            /// 处理状态
            /// </summary>
            public const string CDisplayState = "DisplayState";
            /// <summary>
            /// 学制
            /// </summary>
            public const string CEducationalYear = "EducationalYear";
            /// <summary>
            /// 职位等级
            /// </summary>
            public const string CEmployLevel = "EmployLevel";
            /// <summary>
            /// 学位
            /// </summary>
            public const string CDegreeCode = "DegreeCode";
            /// <summary>
            /// 学历
            /// </summary>
            public const string CEducationalCode = "EducationalCode";
            /// <summary>
            /// 体系分类
            /// </summary>
            public const string CFunctionsType = "FunctionsType";
            /// <summary>
            /// 工作地点
            /// </summary>
            public const string CWorkPlace = "WorkPlace";
            /// <summary>
            /// 指标类型
            /// </summary>
            public const string CIndicatorAType = "IndicatorAType";
            /// <summary>
            /// 指标区分
            /// </summary>
            public const string CIndicatorKind = "IndicatorKind";
            /// <summary>
            /// 面试KPI评价
            /// </summary>
            public const string CInterviewKPILevel = "InterviewKPILevel";
            /// <summary>
            /// 面试结果
            /// </summary>
            public const string CInterviewResult = "InterviewResult";
            /// <summary>
            ///面试类型 
            /// </summary>
            public const string CInterviewType = "InterviewType";
            /// <summary>
            /// 外语种类
            /// </summary>
            public const string CLanguageType = "LanguageType";
            /// <summary>
            /// 离职原因
            /// </summary>
            public const string CLeaveOfficeCause = "LeaveOfficeCause";
            /// <summary>
            /// 水平级别
            /// </summary>
            public const string CLevelCode = "LevelCode";
            /// <summary>
            /// 职位管理区分
            /// </summary>
            public const string CMainPostFlag = "MainPostFlag";
            /// <summary>
            /// 婚否
            /// </summary>
            public const string CMarriageFlagCode = "MarriageFlagCode";
            /// <summary>
            /// 调动类别
            /// </summary>
            public const string CMobilizeCategory = "MobilizeCategory";
            /// <summary>
            /// 国籍
            /// </summary>
            public const string CNationalityCode = "NationalityCode";
            /// <summary>
            /// Offer接受状态
            /// </summary>
            public const string COfferReceiveState = "OfferReceiveState";
            /// <summary>
            /// Offer发送状态
            /// </summary>
            public const string COfferSendState = "OfferSendState";
            /// <summary>
            /// 组织区分
            /// </summary>
            public const string COrgDivision = "OrgDivision";
            /// <summary>
            /// 组织级别
            /// </summary>
            public const string COrgLevel = "OrgLevel";
            /// <summary>
            /// 考核评级
            /// </summary>
            public const string CPEGrade = "PEGrade";
            /// <summary>
            /// 考核类型
            /// </summary>
            public const string CPEPhase = "PEPhase";
            /// <summary>
            /// 考核类型
            /// </summary>
            public const string CPEType = "PEType";
            /// <summary>
            /// 政治面貌
            /// </summary>
            public const string CPolityVisageCode = "PolityVisageCode";
            /// <summary>
            /// 职务状态
            /// </summary>
            public const string CPositionState = "PositionState";
            /// <summary>
            /// 任职资格状态
            /// </summary>
            public const string CQualificationState = "QualificationState";
            /// <summary>
            /// 任职资格类型
            /// </summary>
            public const string CQualificationType = "QualificationType";
            /// <summary>
            /// 招聘广告类型
            /// </summary>
            public const string CRecruitADType = "RecruitADType";
            /// <summary>
            /// 招聘渠道
            /// </summary>
            public const string CRecruitChannel = "RecruitChannel";
            /// <summary>
            /// 招聘类型
            /// </summary>
            public const string CRecruitType = "RecruitType";
            /// <summary>
            /// 拒绝原因
            /// </summary>
            public const string CRefuseReason = "RefuseReason";
            /// <summary>
            /// 合同类型
            /// </summary>
            public const string CContractType = "ContractType";
            /// <summary>
            /// 异动种类
            /// </summary>
            public const string CRegularType = "RegularType";
            /// <summary>
            /// 需求状态
            /// </summary>
            public const string CRequestState = "RequestState";
            /// <summary>
            /// 需求共享状态
            /// </summary>
            public const string CRequestShareState = "RequestShareState";
            /// <summary>
            /// 工资发放比例
            /// </summary>
            public const string CSalaryScale = "SalaryScale";
            /// <summary>
            /// 币种
            /// </summary>
            public const string CContractCurrency = "ContractCurrency";
            /// <summary>
            /// 结算方式
            /// </summary>
            public const string CSettlementWay = "SettlementWay";
            /// <summary>
            /// 性别
            /// </summary>
            public const string CSexCode = "SexCode";
            /// <summary>
            /// 合同签订状态
            /// </summary>
            public const string CSignStateCode = "SignStateCode";
            /// <summary>
            /// 员工类别
            /// </summary>
            public const string CStaffType = "StaffType";
            /// <summary>
            /// 培训类型
            /// </summary>
            public const string CTrainingType = "TrainingType";
            /// <summary>
            /// 调动类型
            /// </summary>
            public const string CTransferType = "TransferType";
            /// <summary>
            /// 院校类别
            /// </summary>
            public const string CUniversityLevel = "UniversityLevel";
            /// <summary>
            /// 评价等级
            /// </summary>
            public const string CVendorGrade = "VendorGrade";
            /// <summary>
            /// 目标设定状态
            /// </summary>
            public const string CPEGoalStatus = "PEGoalStatus";
            /// <summary>
            /// 考核状态
            /// </summary>
            public const string CPEEvaluateStatus = "PEEvaluateStatus";
            /// <summary>
            /// 职位/职务序列
            /// </summary>
            public const string CParentStationCluster = "ParentStationCluster";
            /// <summary>
            /// 考核活动状态
            /// </summary>
            public const string CPEActionStatus = "PEActionStatus";
            /// <summary>
            /// 删除标志
            /// </summary>
            public const string CDeleteFlag = "DeleteFlag";
            /// <summary>
            /// 项目类型
            /// </summary>
            public const string CProjectType = "ProjectType";
            /// <summary>
            /// 业务领域
            /// </summary>
            public const string CIndustryType = "IndustryType";
            /// <summary>
            /// 数据状态
            /// </summary>
            public const string CState = "State";
            /// <summary>
            /// 在职状态
            /// </summary>
            public const string COfficeState = "OfficeState";
            /// <summary>
            /// 目录类型
            /// </summary>
            public const string CCatalogType = "CatalogType";
            /// <summary>
            /// 离职类型
            /// </summary>
            public const string CDimissionType = "DimissionType";
            /// <summary>
            /// 离职去向
            /// </summary>
            public const string CDimissionDistrict = "DimissionDistrict";
            /// <summary>
            /// 职位类型
            /// </summary>
            public const string CPostDivision = "PostDivision";
            /// <summary>
            /// 公司名称
            /// </summary>
            public const string CCompany = "Company";
            /// <summary>
            /// 户口区分
            /// </summary>
            public const string CResidenceFlag = "ResidenceFlag";
            /// <summary>
            /// 个人意向
            /// </summary>
            public const string CPersonWill = "PersonWill";
            /// <summary>
            /// 技能使用年限
            /// </summary>
            public const string CUseYearName = "UseYearName";
            /// <summary>
            /// 技术类别
            /// </summary>
            public const string CSkillSort = "SkillSort";
            /// <summary>
            /// 户口编号
            /// </summary>
            public const string CResidenceCode = "ResidenceCode";
            /// <summary>
            /// 去向详细
            /// </summary>
            public const string CDistrictDetail = "DistrictCompany";
            /// <summary>
            /// 区域
            /// </summary>
            public const string CArea = "Area";
            /// <summary>
            /// 考勤类型
            /// </summary>
            public const string CAttendanceType = "AttendanceType";
            /// <summary>
            /// 调动状态
            /// </summary>
            public const string CTrunState = "TrunState";
            /// <summary>
            /// 人才状态
            /// </summary>
            public const string CWorkState = "WorkState";
            /// <summary>
            /// 任命类型
            /// </summary>
            public const string CInstateType = "InstateType";
            /// <summary>
            /// 推荐意见
            /// </summary>
            public const string CRecommendOpinion = "RecommendOpinion";
            /// <summary>
            /// 查借方式
            /// </summary>
            public const string CBorrowWay = "BorrowWay";
            /// <summary>
            /// 申诉状态
            /// </summary>
            public const string CAppealStatus = "AppealStatus";
            /// <summary>
            /// 定制学校
            /// </summary>
            public const string CCustoomizationShool = "CustoomizationShool";
            /// <summary>
            /// 借用状态
            /// </summary>
            public const string CBorState = "BorState";
            /// <summary>
            /// 借出状态
            /// </summary>
            public const string CBorOutState = "BorOutState";
            /// <summary>
            /// 奖惩类型
            /// </summary>
            public const string CRewPunType = "RewPunType";
            /// <summary>
            /// 职位归属
            /// </summary>
            public const string CParentType = "ParentType";
            /// <summary>
            /// 户籍调动状态
            /// </summary>
            public const string CCensusState = "CensusState";
            /// <summary>
            /// 推荐类型
            /// </summary>
            public const string CRecommendType = "RecommendType";
            /// <summary>
            /// 被推荐人才状态
            /// </summary>
            public const string CRecStaffState = "RecStaffState";
            /// <summary>
            /// 业务资料
            /// </summary>  
            public const string CIndustryArchives = "IndustryArchives";
            /// <summary>
            /// 奖惩区分
            /// </summary>
            public const string CRewPunFlag = "RewPunFlag";
            /// <summary>
            /// 邮箱状态
            /// </summary>
            public const string CMailState = "MailState";
            /// <summary>
            /// 受理状态
            /// </summary>
            public const string CAcceptState = "AcceptState";
            /// <summary>
            /// 出国申请类型
            /// </summary>
            public const string CTGAResType = "TGAResType";
            /// <summary>
            /// 申请状态
            /// </summary>
            public const string CReserveState = "ReserveState";
            /// <summary>
            /// 签证区分
            /// </summary>
            public const string CVisaStyle = "VisaStyle";
            /// <summary>
            /// 签证期间
            /// </summary>
            public const string CVisaPeriod = "VisaPeriod";
            /// <summary>
            /// 签证类型
            /// </summary>
            public const string CVisaType = "VisaType";
            /// <summary>
            /// 人才分类
            /// </summary>
            public const string CTalentIType = "TalentIType";
            /// <summary>
            /// 招聘分类
            /// </summary>
            public const string CRecruitClassify = "RecruitClassify";
            /// <summary>
            /// 需求人才状态
            /// </summary>
            public const string CRecruitTalentState = "RecruitTalentState";
            /// <summary>
            /// 推荐状态
            /// </summary>
            public const string CChooseState = "ChooseState";
            /// <summary>
            /// 是否是主面试官
            /// </summary>
            public const string CIsMaster = "IsMaster";
            /// <summary>
            /// 是否通知
            /// </summary>
            public const string CIsNotify = "IsNotify";
            /// <summary>
            /// 合同是否续签
            /// </summary>
            public const string CReSignCompactFlg = "ReSignCompactFlg";
            /// <summary>
            /// 主职标志
            /// </summary>
            public const string CMainFlag = "MainFlag";
            /// <summary>
            /// 黑名单
            /// </summary>
            public const string CIsBlackList = "IsBlackList";
            /// <summary>
            /// 邀请函发给方
            /// </summary>
            public const string CInvitationLetterIssudeToParty = "InvitationLetterIssudeToParty";
            /// <summary>
            /// 目的国
            /// </summary>
            public const string CDestinationCode = "DestinationCode";
            /// <summary>
            /// 签证办理状态
            /// </summary>
            public const string CVisaTransactState = "VisaTransactState";
            /// <summary>
            /// 保险状态
            /// </summary>
            public const string CInsuranceState = "InsuranceState";
            /// <summary>
            /// 机票状态
            /// </summary>
            public const string CAirticketStatus = "AirticketStatus";
            /// <summary>
            /// 保险申请状态
            /// </summary>
            public const string CInsuranceReserveState = "InsuranceReserveState";
            /// <summary>
            /// 外事状态
            /// </summary>
            public const string CICFAState = "ICFAState";
            /// <summary>
            /// 影响标志
            /// </summary>
            public const string CEffactFlag = "EffactFlag";
            /// <summary>
            /// 银行代号
            /// </summary>
            public const string CBankNum = "BankNum";
            /// <summary>
            /// 申请类型
            /// </summary>
            public const string CReserveType = "ReserveType";
            /// <summary>
            /// 出国人员角色
            /// </summary>
            public const string CRoleCode = "RoleCode";
            /// <summary>
            /// 开发设备来源
            /// </summary>
            public const string CEquipmentSources = "EquipmentSources";
            /// <summary>
            /// 出国理由
            /// </summary>
            public const string CToGoAbroadReason = "ToGoAbroadReason";
            /// <summary>
            /// 出国费用负担者
            /// </summary>
            public const string CCostBurden = "CostBurden";
            /// <summary>
            /// 出国目的
            /// </summary>
            public const string CPurposeCode = "PurposeCode";
            /// <summary>
            /// 成果物
            /// </summary>
            public const string CResultsContentCode = "ResultsContentCode";
            /// <summary>
            /// 过程类型
            /// </summary>
            public const string CProcedureType = "ProcedureType";
            /// <summary>
            /// 招聘批次
            /// </summary>
            public const string CRecruitLevel = "RecruitLevel";
            /// <summary>
            /// 保险费最终负担
            /// </summary>
            public const string CBurdenOnPeople = "BurdenOnPeople";
            /// <summary>
            /// 通知状态
            /// </summary>
            public const string CInformationState = "InformationState";
            /// <summary>
            /// 通知方式
            /// </summary>
            public const string CInformationWay = "InformationWay";
            /// <summary>
            /// 通知对象
            /// </summary>
            public const string CInformationObj = "InformationObj";
            /// <summary>
            /// 是否报到
            /// </summary>
            public const string CRegisterFlg = "RegisterFlg";
            /// <summary>
            /// 是否培训
            /// </summary>
            public const string CTrainFlg = "TrainFlg";
            /// <summary>
            /// 是否违约
            /// </summary>
            public const string CDefaultFlg = "DefaultFlg";
            /// <summary>
            /// Offer状态
            /// </summary>
            public const string COfferState = "OfferState";
            /// <summary>
            /// 是否有效
            /// </summary>
            public const string CIsValid = "IsValid";
            /// <summary>
            /// 面试审核录用状态
            /// </summary>
            public const string CAudEmployState = "AudEmployState";
            /// <summary>
            /// 公司内标志
            /// </summary>
            public const string CIsInnerFlag = "IsInnerFlag";
            /// <summary>
            /// 邮箱标识
            /// </summary>
            public const string CEmailFlg = "EmailFlg";
            /// <summary>
            /// 项目角色
            /// </summary>
            public const string CParentRole = "ParentRole";
            /// <summary>
            /// 简历更新时间
            /// </summary>
            public const string CResumeRenewalTime = "ResumeRenewalTime";
            /// <summary>
            /// 评价状态
            /// </summary>
            public const string CAppraiseState = "AppraiseState";
            /// <summary>
            /// 是否退出项目
            /// </summary>
            public const string CIsExitItem = "IsExitItem";
            /// <summary>
            /// 日期类型
            /// </summary>
            public const string CDateType = "DateType";
            /// <summary>
            /// 生效状态
            /// </summary>
            public const string CEffectState = "EffectState";
            /// <summary>
            /// 结束状态
            /// </summary>
            public const string CEndFlag = "EndFlag";
            /// <summary>
            /// 转正状态
            /// </summary>
            public const string CPositiveState = "PositiveState";
            /// <summary>
            /// 工作场所
            /// </summary>
            public const string CWorkRoomState = "WorkRoomState";
            /// <summary>
            /// 院校所在地
            /// </summary>
            public const string CSite = "Site";
            /// <summary>
            /// 离职共享去向
            /// </summary>
            public const string CLeaveDistrict = "LeaveDistrict";
            /// <summary>
            /// 离职共享管理者类别
            /// </summary>
            public const string CLeaveStaffType = "LeaveStaffType";
            /// <summary>
            /// 离职共享状态
            /// </summary>
            public const string CLeaveState = "LeaveState";
            /// <summary>
            /// 核心员工分类
            /// </summary>
            public const string CCoreStaffType = "CoreStaffType";
            /// <summary>
            /// 绩效考核结果
            /// </summary>
            public const string CPEEvaluateResult = "PEEvaluateResult";
            /// <summary>
            /// 职位类型
            /// </summary>
            public const string CStationType = "StationType";
            /// <summary>
            /// 联络结果
            /// </summary>
            public const string CContractResult = "ContractResult";
            /// <summary>
            /// 异动状态
            /// </summary>
            public const string CRegularState = "RegularState";
            /// <summary>
            /// 审核状态
            /// </summary>
            public const string CApprovalStatus = "ApprovalStatus";
            /// <summary>
            /// 评价设定状态
            /// </summary>
            public const string CVendorGoalStatus = "VendorGoalStatus";
            /// <summary>
            /// 异动评价状态
            /// </summary>
            public const string CRegularVendorState = "RegularVendorState";
            /// <summary>
            /// 合同签署
            /// </summary>
            public const string CIntentSubscription = "IntentSubscription";
            /// <summary>
            /// 入职状态
            /// </summary>
            public const string CEntryState = "EntryState";
            /// <summary>
            /// 审批操作状态
            /// </summary>
            public const string CAppActionState = "AppActionState";
            /// <summary>
            /// 外语等级
            /// </summary>
            public const string CLanguageGrade = "LanguageGrade";
            /// <summary>
            /// 试用期申请类型（画面显示用）
            /// </summary>
            public const string CToProbationType = "ToProbationType";
            /// <summary>
            /// 保险种类
            /// </summary>
            public const string CInsuranceType = "InsuranceType";
            /// <summary>
            /// 出国申请（画面显示用）
            /// </summary>
            public const string CIsVisaTransact = "IsVisaTransact";
            /// <summary>
            /// 英语等级
            /// </summary>
            public const string CEngLanguageLevel = "EngLanguageLevel";
            /// <summary>
            /// 日语等级
            /// </summary>
            public const string CJapLanguageLevel = "JapLanguageLevel";
            /// <summary>
            /// 适用职位
            /// </summary>
            public const string CPEStationLevel = "PEStationLevel";
            /// <summary>
            /// 实习类别
            /// </summary>
            public const string CPracticeType = "PracticeType";
            /// <summary>
            /// 异动考核状态
            /// </summary>
            public const string CRegularExamineState = "RegularExamineState";
            /// <summary>
            /// 实习期申请类型（显示用）
            /// </summary>
            public const string CToPractiseType = "ToPractiseType";
            /// <summary>
            /// 见习期申请类型（显示用）
            /// </summary>
            public const string CToNoviciateType = "ToNoviciateType";
            /// <summary>
            /// 面试成绩
            /// </summary>
            public const string CInterviewScore = "InterviewScore";
            /// <summary>
            /// 业务档案操作状态(导入用)
            /// </summary>
            public const string CArchivesState = "ArchivesState";
            /// <summary>
            /// 证书确认
            /// </summary>
            public const string CCertificateConfirm = "CertificateConfirm";
            /// <summary>
            /// 与本人关系
            /// </summary>
            public const string CSelfConnection = "SelfConnection";
            /// <summary>
            /// 信息安全面试
            /// </summary>
            public const string CInformationSafe = "InformationSafe";
            /// <summary>
            /// 面试类型
            /// </summary>
            public const string CInterviewTypeS = "InterviewTypeS";
            /// <summary>
            /// 信息安全面试结果
            /// </summary>
            public const string CSafeInterviewResult = "SafeInterviewResult";
            /// <summary>
            /// 背景调查
            /// </summary>
            public const string CBackGroundResearch = "BackGroundResearch";
            /// <summary>
            /// 背景调查结果
            /// </summary>
            public const string CBackGroundResearchResult = "BackGroundResearchResult";
            /// <summary>
            /// 是否与部门签订了《DHC转籍JHC协议》
            /// </summary>
            public const string CJHCSiteStatus = "JHCSiteStatus";
            /// <summary>
            /// 月份
            /// </summary>
            public const string CExMonth = "ExMonth";
            /// <summary>
            /// 证书档位
            /// </summary>
            public const string CLevels = "Levels";
            /// <summary>
            /// 成本核算级别
            /// </summary>
            public const string CCostAccLevel = "CostAccLevel";
            /// <summary>
            /// 内部岗位级别
            /// </summary>
            public const string CInternalStationLevel = "InternalStationLevel";
            /// <summary>
            /// 面试评分
            /// </summary>
            public const string CInterviewScroe = "InterviewScroe";
            /// <summary>
            /// 工资使用类型
            /// </summary>
            public const string CSalarayUseType = "SalarayUseType";
            /// <summary>
            /// 工资结构类型
            /// </summary>
            public const string CSalarayStructureType = "SalarayStructureType";
            /// <summary>
            /// 工资项目Code(工资)
            /// </summary>
            public const string CSalarayProjectACode = "SalarayProjectACode";
            /// <summary>
            /// 工资项目Code(补贴)
            /// </summary>
            public const string CSalarayProjectBCode = "SalarayProjectBCode";
            /// <summary>
            /// 工资项目Code(福利)
            /// </summary>
            public const string CSalarayProjectCCode = "SalarayProjectCCode";
            /// <summary>
            /// 工资项目Code(级别)
            /// </summary>
            public const string CSalarayProjectDCode = "SalarayProjectDCode";
            /// <summary>
            /// 工资架构等级(等).
            /// </summary>
            public const string CSalarayStructureGrade = "SalarayStructureGrade";
            /// <summary>
            /// 工资架构等级(级).
            /// </summary>
            public const string CSalarayStructureLevel = "SalarayProjectDCode";
            /// <summary>
            /// 任职资格 评审方式
            /// </summary>
            public const string CAppraisalMethod = "AppraisalMethod";
            /// <summary>
            /// 任职资格 评审材料类型
            /// </summary>
            public const string CMaterialType = "MaterialType";
            /// <summary>
            /// 任职资格 评审类型
            /// </summary>
            public const string CAppraisalType = "AppraisalType";
            /// <summary>
            /// 任职资格 评审级别
            /// </summary>
            public const string CAppraisalGrade = "AppraisalGrade";
            /// <summary>
            /// 任职资格 填表要求
            /// </summary>
            public const string CNeedForm = "NeedForm";
            /// <summary>
            /// 任职资格 评审对象
            /// </summary>
            public const string CAppraisalStaffType = "AppraisalStaffType";
            /// <summary>
            /// 任职资格 评审流程
            /// </summary>
            public const string CAppraisalState = "AppraisalState";
            /// <summary>
            /// 任职资格 资料提交状态
            /// </summary>
            public const string CSubmitState = "SubmitState";
            /// <summary>
            /// 任职资格 业务类型
            /// </summary>
            public const string CProfessionalWorkType = "ProfessionalWorkType";
            /// <summary>
            /// 任职资格 申请情况
            /// </summary>
            public const string CApplyStatus = "ApplyStatus";
            /// <summary>
            /// 任职资格 日语持有证书等级
            /// </summary>
            public const string CJPNCertificateGet = "JPNCertificateGet";
            /// <summary>
            /// 任职资格 英语持有证书等级
            /// </summary>
            public const string CEGLCertificateGet = "EGLCertificateGet";
            /// <summary>
            /// 任职资格 日语未持有证书等级
            /// </summary>
            public const string CJPNCertificate = "JPNCertificate";
            /// <summary>
            /// 任职资格 英语未持有证书等级
            /// </summary>
            public const string CEGLCertificate = "EGLCertificate";
            /// <summary>
            /// 任职资格 作业范围经验
            /// </summary>
            public const string CWorkScopeExperience = "WorkScopeExperience";
            /// <summary>
            /// 任职资格 工作经验
            /// </summary>
            public const string CWorkExperience = "WorkExperience";
            /// <summary>
            /// 任职资格系统中的是和否
            /// </summary>
            public const string CQualificationBool = "QualificationBool";
            /// <summary>
            /// 任职资格 达成情况
            /// </summary>
            public const string CIndicatorReachedStatus = "IndicatorReachedStatus";
            /// <summary>
            /// 任职资格 评审安排情况
            /// </summary>
            public const string CAppraisalSchedule = "AppraisalSchedule";
            /// <summary>
            /// 任职资格 综合评审时间段
            /// </summary>
            public const string CAppraisalPeriod = "AppraisalPeriod";
            /// <summary>
            /// 任职资格 达标情况
            /// </summary>
            public const string CProfessionalReachedStatus = "ProfessionalReachedStatus";
            /// <summary>
            /// 最终结果
            /// </summary>
            public const string CAppraisalResult = "AppraisalResult";
            /// <summary>
            /// 工时比率
            /// </summary>
            public const string CWorkRate = "WorkRate";
            /// <summary>
            /// 内审经验分类
            /// </summary>
            public const string CInternalType = "InternalType";
            /// <summary>
            /// 是否到期
            /// </summary>
            public const string CIsDateEnd = "IsDateEnd";
            /// <summary>
            /// 内审经验
            /// </summary>
            public const string CInnerAppraise = "InnerAppraise";
            /// <summary>
            /// 简历模板类型
            /// </summary>
            public const string CResumeType = "ResumeType";
            /// <summary>
            /// 内审经验
            /// </summary>
            public const string CLocationType = "LocationType";
            /// <summary>
            /// 系统中项目名称
            /// </summary>
            public const string CSysProject = "SysProject";
            /// <summary>
            /// 简历公开程度
            /// </summary>
            public const string CInstrumentPanelAuthority = "InstrumentPanelAuthority";
            /// <summary>
            /// 员工任职资格最终结果生成状态
            /// </summary>
            public const string CFinalResult = "FinalResult";
            /// <summary>
            /// 报销级别
            /// </summary>
            public const string CEbcLevel = "EbcLevel";
            /// <summary>
            /// 职称
            /// </summary>
            public const string CPostID = "PostID";
            /// <summary>
            /// 评价需求
            /// </summary>
            public const string CNeedEvaluate = "NeedEvaluate";
            /// <summary>
            /// 评价状态
            /// </summary>
            public const string CEvaluateAttribute = "EvaluateAttribute";
            /// <summary>
            /// 项目角色名称
            /// </summary>
            public const string CRoleInProject = "RoleInProject";
            /// <summary>
            /// 签证类型(离职办理出国的)
            /// </summary>
            public const string CDimVisaType = "DimVisaType";
            /// <summary>
            /// 出国途径(离职办理出国的)
            /// </summary>
            public const string CWayTGAbroad = "WayTGAbroad";
            /// <summary>
            /// 项目是否经由JHC
            /// </summary>
            public const string CProgramViaJHC = "ProgramViaJHC";
            /// <summary>
            /// 职位类型
            /// </summary>
            public const string CPositionType = "PositionType";
            /// <summary>
            /// 工资发放地
            /// </summary>
            public const string CSalarayPlace = "SalarayPlace";
            /// <summary>
            /// 面试方向
            /// </summary>
            public const string CInterviewDirection = "InterviewDirection";
            /// <summary>
            /// 新机会途径
            /// </summary>
            public const string CNewChancePath = "NewChancePath";
            /// <summary>
            /// 具体离职原因
            /// </summary>
            public const string CDetailLeaveOfficeCause = "DetailLeaveOfficeCause";
            /// <summary>
            /// 最新签证类型
            /// </summary>
            public const string CVisaTypeNew = "VisaTypeNew";
            /// <summary>
            /// 调入调出本部门类别
            /// </summary>
            public const string CInOrOutOrgType = "InOrOutOrgType";
            /// <summary>
            /// 补贴类别
            /// </summary>
            public const string CAllowanceType = "AllowanceType";
            /// <summary>
            /// 业务类型
            /// </summary>
            public const string CBusinessCategory = "BusinessCategory";
            /// <summary>
            /// 指标项
            /// </summary>
            public const string CIndicatorTerms = "IndicatorTerms";
            /// <summary>
            /// 适用阶段
            /// </summary>
            public const string CStage = "Stage";
            /// <summary>
            /// 是否硬指标
            /// </summary>
            public const string CIndicatorMust = "IndicatorMust";
        }
        #endregion

        #region 码表数据键.
        /// <summary>
        /// 码表数据键.
        /// </summary>
        public class ExCodeMasterCode
        {

            /// <summary>
            /// 系统中项目名称.
            /// </summary>
            /// <remarks></remarks>
            public class SysProjectName
            {
                /// <summary>
                /// 姓名
                /// </summary>
                public const string PersonName = "01";
                /// <summary>
                /// 性别
                /// </summary>
                public const string Sex = "02";
                /// <summary>
                /// 移动电话
                /// </summary>
                public const string MobilePhone = "03";
                /// <summary>
                /// 邮箱
                /// </summary>
                public const string Email = "04";
                /// <summary>
                /// 学校名称
                /// </summary>
                public const string UniversityName = "05";
                /// <summary>
                /// 教育经历
                /// </summary>
                public const string StartWorkDate = "06";
                /// <summary>
                /// 学历
                /// </summary>
                public const string EducationalCode = "07";
                /// <summary>
                /// 语言能力
                /// </summary>
                public const string LanguageGrade = "08";
                /// <summary>
                /// 专业
                /// </summary>
                public const string Speciality = "10";
                /// <summary>
                /// 目前年薪
                /// </summary>
                public const string Salary = "12";
                /// <summary>
                /// 期望薪资
                /// </summary>
                public const string HopeSalary = "13";
                /// <summary>
                /// 期望工作地
                /// </summary>
                public const string WorkPlace = "14";
                /// <summary>
                /// 目前作地点
                /// </summary>
                public const string NowWorkPlace = "15";
                /// <summary>
                /// 来源公司
                /// </summary>
                public const string OldCompany = "16";
                /// <summary>
                /// 技能
                /// </summary>
                public const string Skills = "17";
                /// <summary>
                /// 自我评价
                /// </summary>
                public const string SelfAssessment = "18";
                /// <summary>
                /// 出生日期
                /// </summary>
                public const string Birthday = "19";
                /// <summary>
                /// 政治面貌
                /// </summary>
                public const string PoliticalStatus = "20";
                /// <summary>
                /// 婚姻状况
                /// </summary>
                public const string MaritalStatus = "21";
                /// <summary>
                /// 户口
                /// </summary>
                public const string PermanentAddr = "22";
                /// <summary>
                /// 家庭电话
                /// </summary>
                public const string FamilyPhone = "23";
                /// <summary>
                /// 邮编
                /// </summary>
                public const string PostCode = "24";
            }

            /// <summary>
            /// 职位类型.
            /// </summary>
            /// <remarks></remarks>
            public class PositionType
            {
                /// <summary>
                /// 开发
                /// </summary>
                public const string PositionTypeA = "01";
                /// <summary>
                /// 运维
                /// </summary>
                public const string PositionTypeB = "02";
                /// <summary>
                /// 职能
                /// </summary>
                public const string PositionTypeC = "03";
            }

            /// <summary>
            /// 简历模板.
            /// </summary>
            /// <remarks></remarks>
            public class CVType
            {
                /// <summary>
                /// 51JOB
                /// </summary>
                public const string CVType1 = "01";
                /// <summary>
                /// 智联招聘
                /// </summary>
                public const string CVType2 = "02";
            }

            /// <summary>
            /// 政治面貌.
            /// </summary>
            /// <remarks></remarks>
            public class PolityVisageCode
            {
                /// <summary>
                /// 中共党员
                /// </summary>
                public const string PolityVisageCode1 = "01";
                /// <summary>
                /// 中共团员
                /// </summary>
                public const string PolityVisageCode2 = "02";
                /// <summary>
                /// 群众，民主党派，无党派人士
                /// </summary>
                public const string PolityVisageCode3 = "03";
                /// <summary>
                /// 其他
                /// </summary>
                public const string PolityVisageCode4 = "04";
            }

            public class DimissionType
            {
                /// <summary>
                /// 主动离职
                /// </summary>
                public const string DimissionType01 = "01";
                /// <summary>
                /// 被动离职
                /// </summary>
                public const string DimissionType02 = "02";
                /// <summary>
                /// 试用期淘汰
                /// </summary>
                public const string DimissionType03 = "03";
            }

            /// <summary>
            /// NationalityCode国籍.
            /// </summary>
            public class NationalityCode
            {
                /// <summary>
                /// 中国
                /// </summary>
                public const string NationalityCN = "01";
                /// <summary>
                /// 日本
                /// </summary>
                public const string NationalityJP = "02";
                /// <summary>
                /// 美国
                /// </summary>
                public const string NationalityUS = "03";
                /// <summary>
                /// 英国
                /// </summary>
                public const string NationalityEN = "04";
                /// <summary>
                /// 韩国
                /// </summary>
                public const string NationalityKR = "05";
            }

            /// <summary>
            /// 工时比率.
            /// </summary>
            public class WorkRate
            {
                /// <summary>
                /// 50%以下
                /// </summary>
                public const string WorkRate1 = "01";
                /// <summary>
                /// 50～70%
                /// </summary>
                public const string WorkRate2 = "02";
                /// <summary>
                /// 70～90%
                /// </summary>
                public const string WorkRate3 = "03";
                /// <summary>
                /// 90%以上
                /// </summary>
                public const string WorkRate4 = "04";
            }

            /// <summary>
            /// 内审经验分类.
            /// </summary>
            public class InternalType
            {
                /// <summary>
                /// 访谈
                /// </summary>
                public const string InternalType1 = "01";
                /// <summary>
                /// 证据
                /// </summary>
                public const string InternalType2 = "02";
                /// <summary>
                /// 访谈+证据
                /// </summary>
                public const string InternalType3 = "03";
            }

            /// <summary>
            /// 内审经验分类(名称).
            /// </summary>
            public class InternalTypeName
            {
                /// <summary>
                /// 访谈
                /// </summary>
                public const string InternalType1 = "访谈";
                /// <summary>
                /// 证据
                /// </summary>
                public const string InternalType2 = "证据";
                /// <summary>
                /// 访谈+证据.   
                /// </summary>
                public const string InternalType3 = "访谈+证据";
            }


            /// <summary>
            /// 作业范围经验.
            /// </summary>
            public class WorkScopeExperience
            {
                /// <summary>
                /// 要件定义
                /// </summary>
                public const string WorkScopeExperience1 = "01";
                /// <summary>
                /// 基本设计
                /// </summary>
                public const string WorkScopeExperience2 = "02";
                /// <summary>
                /// 机能设计
                /// </summary>
                public const string WorkScopeExperience3 = "03";
                /// <summary>
                /// 详细设计
                /// </summary>
                public const string WorkScopeExperience4 = "04";
                /// <summary>
                /// 编码
                /// </summary>
                public const string WorkScopeExperience5 = "05";
                /// <summary>
                /// 单体测试
                /// </summary>
                public const string WorkScopeExperience6 = "06";
                /// <summary>
                /// 结合测试
                /// </summary>
                public const string WorkScopeExperience7 = "07";
                /// <summary>
                /// 综合测试
                /// </summary>
                public const string WorkScopeExperience8 = "08";
                /// <summary>
                /// 运用测试
                /// </summary>
                public const string WorkScopeExperience9 = "09";
                /// <summary>
                /// 对客户培训
                /// </summary>
                public const string WorkScopeExperience10 = "10";
                /// <summary>
                /// 其他
                /// </summary>
                public const string WorkScopeExperience11 = "11";
            }

            /// <summary>
            /// 工作经验.
            /// </summary>
            public class WorkExperience
            {
                /// <summary>
                /// 需求开发
                /// </summary>
                public const string WorkExperience1 = "01";
                /// <summary>
                /// 概要设计
                /// </summary>
                public const string WorkExperience2 = "02";
                /// <summary>
                /// 详细设计
                /// </summary>
                public const string WorkExperience3 = "03";
                /// <summary>
                /// 编码
                /// </summary>
                public const string WorkExperience4 = "04";
                /// <summary>
                /// 单体测试
                /// </summary>
                public const string WorkExperience5 = "05";
                /// <summary>
                /// 结合测试
                /// </summary>
                public const string WorkExperience6 = "06";
                /// <summary>
                /// 系统测试
                /// </summary>
                public const string WorkExperience7 = "07";
                /// <summary>
                /// IT服务
                /// </summary>
                public const string WorkExperience8 = "08";
                /// <summary>
                /// 系统集成
                /// </summary>
                public const string WorkExperience9 = "09";
            }

            /// <summary>
            /// 是否有过质量事故.
            /// </summary>
            public class QualityMistake
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string Yes = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string No = "02";
            }

            /// <summary>
            /// 评审流程.
            /// </summary>
            /// <remarks></remarks>
            public class AppraisalState
            {
                /// <summary>
                /// 申请审批未开始
                /// </summary>
                public const string ApplyApproveNotStarted = "01";
                /// <summary>
                /// 申请审批中
                /// </summary>
                public const string ApplyApproving = "02";
                /// <summary>
                /// 申请审批通过
                /// </summary>
                public const string ApplyApproveSuccess = "03";
                /// <summary>
                /// 申请审批未通过
                /// </summary>
                public const string ApplyApproveFailed = "04";
                /// <summary>
                /// 线下评审未开始
                /// </summary>
                public const string LineAppraisalNotStarted = "05";
                /// <summary>
                /// 线下评审通过
                /// </summary>
                public const string LineAppraisalSuccess = "06";
                /// <summary>
                /// 线下评审未通过
                /// </summary>
                public const string LineAppraisalFailed = "07";
                /// <summary>
                /// 综合评审未开始
                /// </summary>
                public const string MeettingAppraisalNotStarted = "08";
                /// <summary>
                /// 综合评审通过
                /// </summary>
                public const string MeettingAppraisalSuccess = "09";
                /// <summary>
                /// 综合评审未通过
                /// </summary>
                public const string MeettingAppraisalFailed = "10";

            }

            /// <summary>
            /// 达成情况.
            /// </summary>
            public class IndicatorReachedStatus
            {
                /// <summary>
                /// 已达成
                /// </summary>
                public const string Success = "01";
                /// <summary>
                /// 未达成
                /// </summary>
                public const string Failed = "02";
            }

            /// <summary>
            /// 达成情况(名称).
            /// </summary>
            public class IndicatorReachedStatusName
            {
                /// <summary>
                /// 已达成
                /// </summary>
                public const string Success = "已达成";
                /// <summary>
                /// 未达成
                /// </summary>
                public const string Failed = "未达成";
            }


            /// <summary>
            /// 内部评价.
            /// </summary>
            public class InnerAppraise
            {
                /// <summary>
                /// 优秀
                /// </summary>
                public const string InnerAppraise01 = "01";
                /// <summary>
                /// 良好
                /// </summary>
                public const string InnerAppraise02 = "02";
                /// <summary>
                /// 中等
                /// </summary>
                public const string InnerAppraise03 = "03";
                /// <summary>
                /// 中等以下
                /// </summary>
                public const string InnerAppraise04 = "04";
            }

            /// <summary>
            /// 内部评价(名称).
            /// </summary>
            public class InnerAppraiseName
            {
                /// <summary>
                /// 优秀
                /// </summary>
                public const string InnerAppraise01 = "优秀";
                /// <summary>
                /// 良好
                /// </summary>
                public const string InnerAppraise02 = "良好";
                /// <summary>
                /// 中等
                /// </summary>
                public const string InnerAppraise03 = "中等";
                /// <summary>
                /// 中等以下
                /// </summary>
                public const string InnerAppraise04 = "中等以下";
            }

            /// <summary>
            /// 最终结果状态.
            /// </summary>
            public class PersonSubmitState
            {
                /// <summary>
                /// 未提交
                /// </summary>
                public const string UnSubmit = "01";
                /// <summary>
                /// 已提交
                /// </summary>
                public const string Submited = "02";
            }

            /// <summary>
            /// 最终结果状态.
            /// </summary>
            public class AppraisalResult
            {
                /// <summary>
                /// 通过
                /// </summary>
                public const string Pass = "01";
                /// <summary>
                /// 未通过
                /// </summary>
                public const string UnPass = "02";
                /// <summary>
                /// 撤销
                /// </summary>
                public const string Cancel = "03";
            }

            /// <summary>
            /// 员工任职资格最终结果生成状态.
            /// </summary>
            public class FinalResult
            {
                /// <summary>
                /// 成功
                /// </summary>
                public const string Pass = "01";
                /// <summary>
                /// 失败
                /// </summary>
                public const string UnPass = "02";
                /// <summary>
                /// 未生成
                /// </summary>
                public const string None = "03";
            }

            /// <summary>
            /// 申请情况.
            /// </summary>
            public class ApplyStatus
            {
                /// <summary>
                /// 正常
                /// </summary>
                public const string Normal = "01";
                /// <summary>
                /// 特殊
                /// </summary>
                public const string Sepical = "02";
            }

            /// <summary>
            /// 业务类型(名称).
            /// </summary>
            public class ProfessionalWorkTypeName
            {
                /// <summary>
                /// 对日业务
                /// </summary>
                public const string ProfessionalWorkTypeJP = "对日业务";
                /// <summary>
                /// 欧美业务
                /// </summary>
                public const string ProfessionalWorkTypeENG = "欧美业务";
                /// <summary>
                /// 国内业务
                /// </summary>
                public const string ProfessionalWorkTypeCN = "国内业务";
            }

            /// <summary>
            /// 获得日语证书.
            /// </summary>
            public class JPNCertificateGet
            {
                /// <summary>
                /// 国际/DHC日语一级
                /// </summary>
                public const string JPNCertificate1 = "01";
                /// <summary>
                /// 国际/DHC日语二级
                /// </summary>
                public const string JPNCertificate2 = "02";
                /// <summary>
                /// 国际/DHC日语三级
                /// </summary>
                public const string JPNCertificate3 = "03";
                /// <summary>
                /// N4
                /// </summary>
                public const string JPNCertificate4 = "04";
            }

            /// <summary>
            /// 日语未持有证书等级(名称).
            /// </summary>
            public class JPNCertificateName
            {
                /// <summary>
                /// 国际一级相当
                /// </summary>
                public const string JPN1 = "国际一级相当";
                /// <summary>
                /// 国际二级相当
                /// </summary>
                public const string JPN2 = "国际二级相当";
                /// <summary>
                /// 国际三级相当
                /// </summary>
                public const string JPN3 = "国际三级相当";
            }

            /// <summary>
            /// 获得日语证书(名称).
            /// </summary>
            public class JPNCertificateGetName
            {
                /// <summary>
                /// 国际/DHC日语一级
                /// </summary>
                public const string JPNCertificate1 = "国际/DHC日语一级";
                /// <summary>
                /// 国际/DHC日语二级
                /// </summary>
                public const string JPNCertificate2 = "国际/DHC日语二级";
                /// <summary>
                /// 国际/DHC日语三级
                /// </summary>
                public const string JPNCertificate3 = "国际/DHC日语三级";
                /// <summary>
                /// N4
                /// </summary>
                public const string JPNCertificate4 = "N4";
            }

            /// <summary>
            /// 获得英语证书.
            /// </summary>
            public class ENGCertificateGet
            {
                /// <summary>
                /// 国家英语专业八级
                /// </summary>
                public const string ENGCertificate1 = "01";
                /// <summary>
                /// CET-6
                /// </summary>
                public const string ENGCertificate2 = "02";
                /// <summary>
                /// CET-4.
                /// </summary>
                public const string ENGCertificate3 = "03";
                /// <summary>
                /// 其它
                /// </summary>
                public const string ENGCertificate4 = "04";
            }

            /// <summary>
            /// 获得英语证书(名称).
            /// </summary>
            public class ENGCertificateGetName
            {
                /// <summary>
                /// 国家英语专业八级
                /// </summary>
                public const string ENGCertificate1 = "国家英语专业八级";
                /// <summary>
                /// CET-6
                /// </summary>
                public const string ENGCertificate2 = "CET-6";
                /// <summary>
                /// CET-4
                /// </summary>
                public const string ENGCertificate3 = "CET-4";
                /// <summary>
                /// 其它
                /// </summary>
                public const string ENGCertificate4 = "其它";
            }


            /// <summary>
            /// 评审类型.
            /// </summary>
            public class AppraisalType
            {
                /// <summary>
                /// 项目管理类
                /// </summary>
                public const string AppraisalTypePM = "01";
                /// <summary>
                /// 技术类
                /// </summary>
                public const string AppraisalTypeTE = "02";
                /// <summary>
                /// 质量类
                /// </summary>
                public const string AppraisalTypeQM = "03";
                /// <summary>
                /// 设计类
                /// </summary>
                public const string AppraisalTypeDE = "04";
            }


            /// <summary>
            /// 评审级别.
            /// </summary>
            public class AppraisalGrade
            {
                /// <summary>
                /// 公司级
                /// </summary>
                public const string AppraisalGradeCompany = "01";
                /// <summary>
                /// 事业部级
                /// </summary>
                public const string AppraisalGradeGroup = "02";
                /// <summary>
                /// 部门级
                /// </summary>
                public const string AppraisalGradeDepartment = "03";
                /// <summary>
                /// 无.
                /// </summary>
                public const string AppraisalGradeNone = "04";
            }

            /// <summary>
            /// 评审级别(名称).
            /// </summary>
            public class AppraisalGradeName
            {
                /// <summary>
                /// 公司级
                /// </summary>
                public const string AppraisalGradeCompany = "公司级";
                /// <summary>
                /// 事业部级
                /// </summary>
                public const string AppraisalGradeGroup = "事业部级";
                /// <summary>
                /// 部门级
                /// </summary>
                public const string AppraisalGradeDepartment = "部门级";
                /// <summary>
                /// 无
                /// </summary>
                public const string AppraisalGradeNone = "无";
            }

            /// <summary>
            /// 评审材料类型.
            /// </summary>
            public class MaterialType
            {
                /// <summary>
                /// 项目管理论文
                /// </summary>
                public const string MaterialTypePM = "01";
                /// <summary>
                /// 技术方案
                /// </summary>
                public const string MaterialTypeTE = "02";
                /// <summary>
                /// 无
                /// </summary>
                public const string MaterialTypeNone = "03";
            }

            /// <summary>
            /// 评审方式.
            /// </summary>
            public class AppraisalMethod
            {
                /// <summary>
                /// 线下评审
                /// </summary>
                public const string AppraisalMethodLine = "01";
                /// <summary>
                /// 综合评审
                /// </summary>
                public const string AppraisalMethodMeetting = "02";
                /// <summary>
                /// 线下和综合评审
                /// </summary>
                public const string AppraisalMethodAll = "03";
            }

            /// <summary>
            /// 业务类型.
            /// </summary>
            public class ProfessionalWorkType
            {
                /// <summary>
                /// 对日业务
                /// </summary>
                public const string ProfessionalWorkTypeJP = "01";
                /// <summary>
                /// 欧美业务
                /// </summary>
                public const string ProfessionalWorkTypeENG = "02";
                /// <summary>
                /// 国内业务
                /// </summary>
                public const string ProfessionalWorkTypeCN = "03";
            }

            /// <summary>
            /// 任职资格系统中的是和否.
            /// </summary>
            public class QualificationBool
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string QualificationYes = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string QualificationNo = "02";
            }

            /// <summary>
            /// 提交状态.
            /// </summary>
            public class SubmitState
            {
                /// <summary>
                /// 未提交
                /// </summary>
                public const string SubmitStateA = "01";
                /// <summary>
                /// 已提交
                /// </summary>
                public const string SubmitStateB = "02";
                /// <summary>
                /// 无需提交
                /// </summary>
                public const string SubmitStateC = "03";
            }

            /// <summary>
            /// 提交状态(名称).
            /// </summary>
            public class SubmitStateName
            {
                /// <summary>
                /// 未提交
                /// </summary>
                public const string SubmitStateA = "未提交";
                /// <summary>
                /// 已提交
                /// </summary>
                public const string SubmitStateB = "已提交";
                /// <summary>
                /// 无需提交
                /// </summary>
                public const string SubmitStateC = "无需提交";
            }

            /// <summary>
            /// 工资使用类型.
            /// </summary>
            public class SalarayUseType
            {
                /// <summary>
                /// 招聘需求设定
                /// </summary>
                public const string SalarayUseType01 = "01";
                /// <summary>
                /// 实习期设定
                /// </summary>
                public const string SalarayUseType02 = "02";
                /// <summary>
                /// 试用期设定
                /// </summary>
                public const string SalarayUseType03 = "03";
                /// <summary>
                /// 转正设定
                /// </summary>
                public const string SalarayUseType04 = "04";
            }

            /// <summary>
            /// 工资结构类型.
            /// </summary>
            public class SalarayStructureType
            {
                /// <summary>
                /// 工资
                /// </summary>
                public const string SalarayStructureType01 = "01";
                /// <summary>
                /// 补贴
                /// </summary>
                public const string SalarayStructureType02 = "02";
                /// <summary>
                /// 福利
                /// </summary>
                public const string SalarayStructureType03 = "03";
                /// <summary>
                /// 级别
                /// </summary>
                public const string SalarayStructureType04 = "04";
            }

            /// <summary>
            /// 工资项目Code(工资).
            /// </summary>
            public class SalarayProjectACode
            {
                /// <summary>
                /// 基本工资
                /// </summary>
                public const string SalarayProjectACode01 = "01";
                /// <summary>
                /// 职位工资
                /// </summary>
                public const string SalarayProjectACode02 = "02";
                /// <summary>
                /// 评价工资
                /// </summary>
                public const string SalarayProjectACode03 = "03";
                /// <summary>
                /// 奖金
                /// </summary>
                public const string SalarayProjectACode04 = "04";
                /// <summary>
                /// 备注
                /// </summary>
                public const string SalarayProjectACode05 = "05";
            }

            /// <summary>
            /// 工资项目Code(补贴).
            /// </summary>
            public class SalarayProjectBCode
            {
                /// <summary>
                /// 餐补
                /// </summary>
                public const string SalarayProjectBCode01 = "01";
                /// <summary>
                /// 通讯补贴
                /// </summary>
                public const string SalarayProjectBCode02 = "02";
                /// <summary>
                /// 交通补贴
                /// </summary>
                public const string SalarayProjectBCode03 = "03";
                /// <summary>
                /// 项目补贴
                /// </summary>
                public const string SalarayProjectBCode04 = "04";
                /// <summary>
                /// 采暖补贴
                /// </summary>
                public const string SalarayProjectBCode05 = "05";
                /// <summary>
                /// 备注
                /// </summary>
                public const string SalarayProjectBCode06 = "06";
            }

            /// <summary>
            /// 工资项目Code(福利).
            /// </summary>
            public class SalarayProjectCCode
            {
                /// <summary>
                /// 公积金
                /// </summary>
                public const string SalarayProjectCCode01 = "01";
                /// <summary>
                /// 社会保险
                /// </summary>
                public const string SalarayProjectCCode02 = "02";
                /// <summary>
                /// 备注
                /// </summary>
                public const string SalarayProjectCCode03 = "03";
            }

            /// <summary>
            /// 工资项目Code(级别).
            /// </summary>
            public class SalarayProjectDCode
            {
                /// <summary>
                /// 等级
                /// </summary>
                public const string SalarayProjectDCode01 = "01";
                /// <summary>
                /// 级别
                /// </summary>
                public const string SalarayProjectDCode02 = "02";
            }


            /// <summary>
            /// 任职资格类型.
            /// </summary>
            public class QualificationType
            {
                /// <summary>
                /// 项目管理序列
                /// </summary>
                public const string QualificationType01 = "01";
                /// <summary>
                /// 设计序列
                /// </summary>
                public const string QualificationType02 = "02";
                /// <summary>
                /// 技术序列
                /// </summary>
                public const string QualificationType03 = "03";
                /// <summary>
                /// 质量管理序列
                /// </summary>
                public const string QualificationType04 = "04";
                /// <summary>
                /// 架构序列
                /// </summary>
                public const string QualificationType05 = "05";
                /// <summary>
                /// 分析师序列
                /// </summary>
                public const string QualificationType06 = "06";
                /// <summary>
                /// 咨询序列
                /// </summary>
                public const string QualificationType07 = "07";
                /// <summary>
                /// 工程师序列
                /// </summary>
                public const string QualificationType08 = "08";
                /// <summary>
                /// 品质管理序列
                /// </summary>
                public const string QualificationType09 = "09";
                /// <summary>
                /// 销售序列
                /// </summary>
                public const string QualificationType10 = "10";
                /// <summary>
                /// 系统集成序列
                /// </summary>
                public const string QualificationType11 = "11";
                /// <summary>
                /// 服务管理序列
                /// </summary>
                public const string QualificationType12 = "12";
                /// <summary>
                /// 技术支持序列
                /// </summary>
                public const string QualificationType13 = "13";
                /// <summary>
                /// 业务支持序列
                /// </summary>
                public const string QualificationType14 = "14";
                /// <summary>
                /// helpdesk
                /// </summary>
                public const string QualificationType15 = "15";
            }

            /// <summary>
            /// 任职资格类型ID.
            /// </summary>
            public class QualificationTypeID
            {
                /// <summary>
                /// 项目管理序列
                /// </summary>
                public const string QualificationTypeID01 = "QUA_1";
                /// <summary>
                /// 设计序列
                /// </summary>
                public const string QualificationTypeID02 = "QUT_2";
                /// <summary>
                /// 技术序列
                /// </summary>
                public const string QualificationTypeID03 = "QUT_3";
                /// <summary>
                /// 质量管理序列
                /// </summary>
                public const string QualificationTypeID04 = "QUT_4";
                /// <summary>
                /// 架构序列
                /// </summary>
                public const string QualificationTypeID05 = "QUT_5";
                /// <summary>
                /// 分析师序列
                /// </summary>
                public const string QualificationTypeID06 = "QUT_6";
                /// <summary>
                /// 咨询序列
                /// </summary>
                public const string QualificationTypeID07 = "QUT_7";
                /// <summary>
                /// 工程师序列
                /// </summary>
                public const string QualificationTypeID08 = "QUT_8";
                /// <summary>
                /// 品质管理序列
                /// </summary>
                public const string QualificationTypeID09 = "QUT_9";
                /// <summary>
                /// 销售序列
                /// </summary>
                public const string QualificationTypeID10 = "QUT_10";
                /// <summary>
                /// 系统集成序列
                /// </summary>
                public const string QualificationTypeID11 = "QUT_11";
                /// <summary>
                /// 服务管理序列
                /// </summary>
                public const string QualificationTypeID12 = "QUT_12";
                /// <summary>
                /// 技术支持序列
                /// </summary>
                public const string QualificationTypeID13 = "QUT_13";
                /// <summary>
                /// 业务支持序列
                /// </summary>
                public const string QualificationTypeID14 = "QUT_14";
                /// <summary>
                /// helpdesk
                /// </summary>
                public const string QualificationTypeID15 = "QUT_15";
            }
            /// <summary>
            /// 目录类型.
            /// </summary>
            public class CatalogType
            {
                /// <summary>
                /// 目录内
                /// </summary>
                public const string CatalogTypeInner = "01";
                /// <summary>
                /// 目录外
                /// </summary>
                public const string CatalogTypeOut = "02";
            }

            public class InformationSafe
            {
                /// <summary>
                /// 需要
                /// </summary>
                public const string InformationSafe01 = "01";
                /// <summary>
                /// 不需要
                /// </summary>
                public const string InformationSafe02 = "02";
            }

            public class InterviewTypeS
            {
                /// <summary>
                /// 普通面试
                /// </summary>
                public const string InterviewTypeS01 = "01";
                /// <summary>
                /// 信息安全面试
                /// </summary>
                public const string InterviewTypeS02 = "02";
            }

            public class SafeInterviewResult
            {
                /// <summary>
                /// 合格
                /// </summary>
                public const string SafeInterviewResult01 = "01";
                /// <summary>
                /// 不合格
                /// </summary>
                public const string SafeInterviewResult02 = "02";
            }

            public class BackGroundResearchResult
            {
                /// <summary>
                /// 合格
                /// </summary>
                public const string BackGroundResearchResult01 = "01";
                /// <summary>
                /// 不合格
                /// </summary>
                public const string BackGroundResearchResult02 = "02";
                /// <summary>
                /// 不需要
                /// </summary>
                public const string BackGroundResearchResult03 = "03";
            }

            public class BackGroundResearch
            {
                /// <summary>
                /// 需要
                /// </summary>
                public const string BackGroundResearch01 = "01";
                /// <summary>
                /// 不需要
                /// </summary>
                public const string BackGroundResearch02 = "02";
            }

            public class SeachStaffType
            {
                /// <summary>
                /// 精确到组织
                /// </summary>
                public const string TypeOrg = "01";
                /// <summary>
                /// 精确到帐套
                /// </summary>
                public const string TypeAcc = "02";
                /// <summary>
                /// 全部
                /// </summary>
                public const string TypeAll = "03";
            }

            /// <summary>
            /// 业务档案材料.
            /// </summary>
            /// <remarks></remarks>
            public class IndustryArchives
            {
                /// <summary>
                /// 身份证复印件
                /// </summary>
                public const string IndustryArchives01 = "01";
                /// <summary>
                /// 学历证明复印件
                /// </summary>
                public const string IndustryArchives02 = "02";
                /// <summary>
                /// 学位证明复印件
                /// </summary>
                public const string IndustryArchives03 = "03";
                /// <summary>
                /// 外语等级证书复印件
                /// </summary>
                public const string IndustryArchives04 = "04";
                /// <summary>
                /// 户口复印件
                /// </summary>
                public const string IndustryArchives05 = "05";
                /// <summary>
                /// 体检报告
                /// </summary>
                public const string IndustryArchives06 = "06";
                /// <summary>
                /// 保密协议
                /// </summary>
                public const string IndustryArchives07 = "07";
                /// <summary>
                /// 个人信息使用授权书
                /// </summary>
                public const string IndustryArchives08 = "08";
                /// <summary>
                /// 入职承诺书
                /// </summary>
                public const string IndustryArchives09 = "09";
                /// <summary>
                /// 解除劳动合同证明书或失业证
                /// </summary>
                public const string IndustryArchives10 = "10";
            }

            /// <summary>
            /// 业务档案操作状态(导入用)--CodeName.
            /// </summary>
            /// <remarks></remarks>
            public class ArchivesState
            {
                public const string ArchivesState01 = "0";
                public const string ArchivesState02 = "1";
            }

            /// <summary>
            /// 离职去向.
            /// </summary>
            /// <remarks></remarks>
            public class DimissionDistrict
            {
                /// <summary>
                /// 大连同行
                /// </summary>
                public const string DimissionDistrict06 = "06";
                /// <summary>
                /// 去外地发展
                /// </summary>
                public const string DimissionDistrict07 = "07";
                /// <summary>
                /// 改行
                /// </summary>
                public const string DimissionDistrict08 = "08";
                /// <summary>
                /// 创业
                /// </summary>
                public const string DimissionDistrict09 = "09";
                /// <summary>
                /// 出国
                /// </summary>
                public const string DimissionDistrict10 = "10";
                /// <summary>
                /// 再教育
                /// </summary>
                public const string DimissionDistrict11 = "11";
                /// <summary>
                /// 公务员/国企.
                /// </summary>
                public const string DimissionDistrict12 = "12";
                /// <summary>
                /// 手动填写
                /// </summary>
                public const string DimissionDistrict13 = "13";
            }


            /// <summary>
            /// 离职去向.
            /// </summary>
            /// <remarks></remarks>
            public class LeaveDistrict
            {
                /// <summary>
                /// 大连
                /// </summary>
                public const string leaveDistrict01 = "01";
                /// <summary>
                /// 北京
                /// </summary>
                public const string leaveDistrict02 = "02";
                /// <summary>
                /// 沈阳
                /// </summary>
                public const string leaveDistrict03 = "03";
                /// <summary>
                /// 日本
                /// </summary>
                public const string leaveDistrict04 = "04";
                /// <summary>
                /// 上海
                /// </summary>
                public const string leaveDistrict05 = "05";
                /// <summary>
                /// 深圳
                /// </summary>
                public const string leaveDistrict06 = "06";
                /// <summary>
                /// 西安
                /// </summary>
                public const string leaveDistrict07 = "07";
                /// <summary>
                /// 哈尔滨
                /// </summary>
                public const string leaveDistrict08 = "08";
                /// <summary>
                /// 武汉
                /// </summary>
                public const string leaveDistrict09 = "09";
                /// <summary>
                /// 南京
                /// </summary>
                public const string leaveDistrict10 = "10";
                /// <summary>
                /// 青岛
                /// </summary>
                public const string leaveDistrict11 = "11";
                /// <summary>
                /// 天津
                /// </summary>
                public const string leaveDistrict12 = "12";
                /// <summary>
                /// 长春
                /// </summary>
                public const string leaveDistrict13 = "13";
                /// <summary>
                /// 杭州
                /// </summary>
                public const string leaveDistrict14 = "14";
                /// <summary>
                /// 广州
                /// </summary>
                public const string leaveDistrict15 = "15";
            }
            /// <summary>
            /// 离职共享管理者类别.
            /// </summary>
            /// <remarks></remarks>
            public class LeaveStaffType
            {
                /// <summary>
                /// 社内员工
                /// </summary>
                public const string LeaveStaffType00 = "00";
                /// <summary>
                /// 社外员工
                /// </summary>
                public const string LeaveStaffType01 = "01";
            }
            /// <summary>
            /// 离职共享管理者类别.
            /// </summary>
            /// <remarks></remarks>
            public class LeaveState
            {
                /// <summary>
                /// 我没共享的
                /// </summary>
                public const string LeaveState00 = "00";
                /// <summary>
                /// 我共享给他人的
                /// </summary>
                public const string LeaveState01 = "01";
                /// <summary>
                /// 他人共享给我的
                /// </summary>
                public const string LeaveState02 = "02";
            }


            /// <summary>
            /// 日语等级.
            /// </summary>
            /// <remarks></remarks>
            public class JapLanguageLevel
            {
                /// <summary>
                /// 大学日语四级
                /// </summary>
                public const string JapLanguageLevelA = "01";
                /// <summary>
                /// 大学日语六级
                /// </summary>
                public const string JapLanguageLevelB = "02";
                /// <summary>
                /// 专业四级
                /// </summary>
                public const string JapLanguageLevelC = "03";
                /// <summary>
                /// 专业八级
                /// </summary>
                public const string JapLanguageLevelD = "04";
                /// <summary>
                /// 国际一级N1.
                /// </summary>
                public const string JapLanguageLevelE = "05";
                /// <summary>
                /// 国际二级N2.
                /// </summary>
                public const string JapLanguageLevelF = "06";
                /// <summary>
                /// 国际三级N3.
                /// </summary>
                public const string JapLanguageLevelG = "07";
                /// <summary>
                /// 国际四级N4.
                /// </summary>
                public const string JapLanguageLevelH = "08";
                /// <summary>
                /// 社内一级
                /// </summary>
                public const string JapLanguageLevelI = "09";
                /// <summary>
                /// 社内二级
                /// </summary>
                public const string JapLanguageLevelJ = "10";
                /// <summary>
                /// 社内三级
                /// </summary>
                public const string JapLanguageLevelK = "11";
                /// <summary>
                /// 社内四级
                /// </summary>
                public const string JapLanguageLevelL = "12";
            }

            /// <summary>
            /// 英语等级.
            /// </summary>
            /// <remarks></remarks>
            public class EngLanguageLevel
            {
                /// <summary>
                /// 大学英语四级
                /// </summary>
                public const string EngLanguageLevelA = "01";
                /// <summary>
                /// 大学英语六级
                /// </summary>
                public const string EngLanguageLevelB = "02";
                /// <summary>
                /// 专业四级
                /// </summary>
                public const string EngLanguageLevelC = "03";
                /// <summary>
                /// 专业八级
                /// </summary>
                public const string EngLanguageLevelD = "04";
            }

            /// <summary>
            /// 面试成绩.
            /// </summary>
            /// <remarks></remarks>
            public class InterviewScore
            {
                /// <summary>
                /// A+
                /// </summary>
                public const string InterviewScoreA = "01";
                /// <summary>
                /// A
                /// </summary>
                public const string InterviewScoreB = "02";
                /// <summary>
                /// A-
                /// </summary>
                public const string InterviewScoreC = "03";
                /// <summary>
                /// B+
                /// </summary>
                public const string InterviewScoreD = "04";
                /// <summary>
                /// B
                /// </summary>
                public const string InterviewScoreE = "05";
                /// <summary>
                /// B-
                /// </summary>
                public const string InterviewScoreF = "06";
                /// <summary>
                /// C+
                /// </summary>
                public const string InterviewScoreG = "07";
                /// <summary>
                /// C
                /// </summary>
                public const string InterviewScoreH = "08";
                /// <summary>
                /// C-
                /// </summary>
                public const string InterviewScoreI = "09";
                /// <summary>
                /// D+
                /// </summary>
                public const string InterviewScoreJ = "10";
                /// <summary>
                /// D
                /// </summary>
                public const string InterviewScoreK = "11";
                /// <summary>
                /// D-
                /// </summary>
                public const string InterviewScoreL = "12";

            }

            /// <summary>
            /// 业务区分.
            /// </summary>
            /// <remarks></remarks>
            public class OldAreaDivision
            {
                /// <summary>
                /// 国内
                /// </summary>
                public const string OldAreaDivision_1 = "0";
                /// <summary>
                /// 国际
                /// </summary>
                public const string OldAreaDivision_2 = "1";
                /// <summary>
                /// 职能
                /// </summary>
                public const string OldAreaDivision_3 = "2";
            }
            /// <summary>
            /// 业务区分.
            /// </summary>
            /// <remarks></remarks>
            public class BussinessDivisionCode
            {
                /// <summary>
                /// 国内
                /// </summary>
                public const string BussinessDivisionCode_01 = "01";
                /// <summary>
                /// 国际
                /// </summary>
                public const string BussinessDivisionCode_02 = "02";
                /// <summary>
                /// 职能
                /// </summary>
                public const string BussinessDivisionCode_03 = "03";
            }
            /// <summary>
            /// 部门区分.
            /// </summary>
            /// <remarks></remarks>
            public class OldOrgDivision
            {
                /// <summary>
                /// 职能
                /// </summary>
                public const string OldDep_1 = "Dep_1";
                /// <summary>
                /// 业务
                /// </summary>
                public const string OldDep_2 = "Dep_2";
                /// <summary>
                /// 国际业务
                /// </summary>
                public const string OldDep_3 = "Dep_3";
                /// <summary>
                /// 国内业务
                /// </summary>
                public const string OldDep_4 = "Dep_4";
                /// <summary>
                /// 公司
                /// </summary>
                public const string OldDep_5 = "Dep_5";
            }

            /// <summary>
            /// 部门区分.
            /// </summary>
            /// <remarks></remarks>
            public class OrgDivision
            {

                /// <summary>
                /// 职能部门
                /// </summary>
                public const string OrgDivision_01 = "01";
                /// <summary>
                /// 业务部门
                /// </summary>
                public const string OrgDivision_02 = "02";
                /// <summary>
                /// 公司
                /// </summary>
                public const string OrgDivision_03 = "03";
            }

            /// <summary>
            /// 组织级别.
            /// </summary>
            /// <remarks></remarks>
            public class OldOrgLevel
            {
                /// <summary>
                /// 公司
                /// </summary>
                public const string OldOrgLevel01 = "Orl_10";
                /// <summary>
                /// 子公司
                /// </summary>
                public const string OldOrgLevel02 = "Orl_20";
                /// <summary>
                /// 业务集团
                /// </summary>
                public const string OldOrgLevel03 = "Orl_25";
                /// <summary>
                /// 事业部
                /// </summary>
                public const string OldOrgLevel04 = "Orl_30";
                /// <summary>
                /// 开发中心
                /// </summary>
                public const string OldOrgLevel05 = "Orl_40";
                /// <summary>
                /// 部门
                /// </summary>
                public const string OldOrgLevel06 = "Orl_50";
                /// <summary>
                /// 项目
                /// </summary>
                public const string OldOrgLevel07 = "Orl_60";
            }

            /// <summary>
            /// 员工类别.
            /// </summary>
            /// <remarks></remarks>
            public class OldStaffType
            {
                /// <summary>
                /// 正式
                /// </summary>
                public const string OldStaffType01 = "Sft_1";
                /// <summary>
                /// 试用
                /// </summary>
                public const string OldStaffType02 = "Sft_2";
                /// <summary>
                /// 实习
                /// </summary>
                public const string OldStaffType03 = "Sft_3";
                /// <summary>
                /// 外协
                /// </summary>
                public const string OldStaffType04 = "Sft_4";
                /// <summary>
                /// 其他
                /// </summary>
                public const string OldStaffType05 = "Sft_5";
                /// <summary>
                /// 外聘
                /// </summary>
                public const string OldStaffType06 = "Sft_6";
                /// <summary>
                /// 见习
                /// </summary>
                public const string OldStaffType07 = "Sft_7";
                /// <summary>
                /// 劳务
                /// </summary>
                public const string OldStaffType08 = "Sft_8";
            }

            /// <summary>
            /// 见习期申请类型.
            /// </summary>
            /// <remarks></remarks>
            public class ToNoviciateType
            {
                /// <summary>
                /// 终止雇佣
                /// </summary>
                public const string ToNoviciateType01 = "01";
                /// <summary>
                /// 延长见习
                /// </summary>
                public const string ToNoviciateType02 = "02";
                /// <summary>
                /// 转实习
                /// </summary>
                public const string ToNoviciateType03 = "03";
                /// <summary>
                /// 转试用
                /// </summary>
                public const string ToNoviciateType04 = "04";
                /// <summary>
                /// 转正
                /// </summary>
                public const string ToNoviciateType05 = "05";
            }

            /// <summary>
            /// 实习期申请类型.
            /// </summary>
            /// <remarks></remarks>
            public class ToPractiseType
            {
                /// <summary>
                /// 终止雇佣
                /// </summary>
                public const string ToPractiseType01 = "01";
                /// <summary>
                /// 延长实习
                /// </summary>
                public const string ToPractiseType02 = "02";
                /// <summary>
                /// 转试用
                /// </summary>
                public const string ToPractiseType03 = "03";
                /// <summary>
                /// 转正
                /// </summary>
                public const string ToPractiseType04 = "04";
            }
            /// <summary>
            /// 异动考核状态.
            /// </summary>
            /// <remarks></remarks>
            public class RegularExamineState
            {
                /// <summary>
                /// 目标未设定
                /// </summary>
                public const string RegularExamineState01 = "01";
                /// <summary>
                /// 目标未确认
                /// </summary>
                public const string RegularExamineState02 = "02";
                /// <summary>
                /// 目标已确认
                /// </summary>
                public const string RegularExamineState03 = "03";
                /// <summary>
                /// 评价未确认
                /// </summary>
                public const string RegularExamineState04 = "04";
                /// <summary>
                /// 评价已确认
                /// </summary>
                public const string RegularExamineState05 = "05";
            }

            /// <summary>
            /// 面试结果.
            /// </summary>
            /// <remarks></remarks>
            public class InterviewResult
            {
                /// <summary>
                /// 合格（高）
                /// </summary>
                public const string InterviewResult01 = "01";
                /// <summary>
                /// 合格（中）
                /// </summary>
                public const string InterviewResult02 = "02";
                /// <summary>
                /// 合格（低）
                /// </summary>
                public const string InterviewResult03 = "03";
                /// <summary>
                /// 不合格
                /// </summary>
                public const string InterviewResult04 = "04";
                /// <summary>
                /// 不予考虑
                /// </summary>
                public const string InterviewResult05 = "05";
                /// <summary>
                /// 不合格-不予考虑
                /// </summary>
                public const string InterviewResult06 = "06";
                /// <summary>
                /// 可以试用
                /// </summary>
                public const string InterviewResult07 = "07";
                /// <summary>
                /// 放弃面试
                /// </summary>
                public const string InterviewResult08 = "08";
            }

            /// <summary>
            /// 实习类别.
            /// </summary>
            /// <remarks></remarks>
            public class PracticeType
            {
                /// <summary>
                /// DHEE实习
                /// </summary>
                public const string PracticeType01 = "01";
                /// <summary>
                /// 签三方协议
                /// </summary>
                public const string PracticeType02 = "02";
                /// <summary>
                /// 其他实习人员
                /// </summary>
                public const string PracticeType03 = "03";
            }

            /// <summary>
            /// 适用职位.
            /// </summary>
            /// <remarks></remarks>
            public class PEStationLevel
            {
                /// <summary>
                /// 项目管理类
                /// </summary>
                public const string PEStationLevel01 = "01";
                /// <summary>
                /// 技术开发类
                /// </summary>
                public const string PEStationLevel02 = "02";
                /// <summary>
                /// 辅助开发类
                /// </summary>
                public const string PEStationLevel03 = "03";
                /// <summary>
                /// IT服务类
                /// </summary>
                public const string PEStationLevel04 = "04";
                /// <summary>
                /// 职能类
                /// </summary>
                public const string PEStationLevel05 = "05";
                /// <summary>
                /// 通用类
                /// </summary>
                public const string PEStationLevel06 = "06";

            }

            /// <summary>
            /// 出国申请.
            /// </summary>
            /// <remarks></remarks>
            public class IsVisaTransact
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string IsVisaTransact01 = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string IsVisaTransact02 = "02";
            }

            /// <summary>
            /// 通知状态.
            /// </summary>
            /// <remarks></remarks>
            public class InformationState
            {
                /// <summary>
                /// 未通知
                /// </summary>
                public const string InformationState01 = "01";
                /// <summary>
                /// 已通知
                /// </summary>
                public const string InformationState02 = "02";
            }

            /// <summary>
            /// 保险种类.
            /// </summary>
            /// <remarks></remarks>
            public class InsuranceType
            {
                /// <summary>
                /// 海外急性病意外保险
                /// </summary>
                public const string InsuranceType01 = "01";
            }

            /// <summary>
            /// 试用期申请类型（画面显示用）.
            /// </summary>
            /// <remarks></remarks>
            public class ToProbationType
            {
                /// <summary>
                /// 终止雇佣
                /// </summary>
                public const string ToProbationType01 = "01";
                /// <summary>
                /// 转正
                /// </summary>
                public const string ToProbationType02 = "02";
                /// <summary>
                /// 延长试用
                /// </summary>
                public const string ToProbationType03 = "03";
            }
            /// <summary>
            /// 权限操作状态.
            /// </summary>
            /// <remarks></remarks>
            public class PersonWill
            {
                /// <summary>
                /// 续签
                /// </summary>
                public const string PersonWill01 = "01";
                /// <summary>
                /// 不续签
                /// </summary>
                public const string PersonWill02 = "02";
            }


            /// <summary>
            /// SLA类别.
            /// </summary>
            /// <remarks></remarks>
            public class SlaType
            {
                /// <summary>
                /// 招聘
                /// </summary>
                public const string SlaType01 = "01";
            }
            /// <summary>
            /// SLA子类别.
            /// </summary>
            /// <remarks></remarks>
            public class SlaSubType01
            {
                /// <summary>
                /// 招聘活动
                /// </summary>
                public const string SlaSubType01_01 = "01";
            }


            /// <summary>
            /// 外语等级.
            /// </summary>
            /// <remarks></remarks>
            public class LanguageGrade
            {
                /// <summary>
                /// 1级
                /// </summary>
                public const string LanguageGrade01 = "01";
                /// <summary>
                /// 2级
                /// </summary>
                public const string LanguageGrade02 = "02";
                /// <summary>
                /// 3级
                /// </summary>
                public const string LanguageGrade03 = "03";
                /// <summary>
                /// 4级
                /// </summary>
                public const string LanguageGrade04 = "04";
                /// <summary>
                /// 5级
                /// </summary>
                public const string LanguageGrade05 = "05";
                /// <summary>
                /// 6级
                /// </summary>
                public const string LanguageGrade06 = "06";
                /// <summary>
                /// 7级
                /// </summary>
                public const string LanguageGrade07 = "07";
                /// <summary>
                /// 8级
                /// </summary>
                public const string LanguageGrade08 = "08";
                /// <summary>
                /// 其他
                /// </summary>
                public const string LanguageGrade99 = "99";
            }

            /// <summary>
            /// 权限操作状态.
            /// </summary>
            /// <remarks></remarks>
            public class AuthorFlg
            {
                /// <summary>
                /// 追加
                /// </summary>
                public const string AuthorCreate = "1";
                /// <summary>
                /// 重置
                /// </summary>
                public const string AuthorClear = "0";
            }

            /// <summary>
            /// 审批操作状态.
            /// </summary>
            /// <remarks></remarks>
            public class AppActionState
            {
                /// <summary>
                /// 待审批
                /// </summary>
                public const string AppActionState01 = "01";
                /// <summary>
                /// 审批中
                /// </summary>
                public const string AppActionState02 = "02";
                /// <summary>
                /// 审批通过
                /// </summary>
                public const string AppActionState03 = "03";
                /// <summary>
                /// 审批驳回
                /// </summary>
                public const string AppActionState04 = "04";
            }

            /// <summary>
            /// 是否是主面试官.
            /// </summary>
            /// <remarks></remarks>
            public class IsMaster
            {
                /// <summary>
                /// 主面试官
                /// </summary>
                public const string IsMasterA = "01";
            }

            /// <summary>
            /// 通知状态.
            /// </summary>
            /// <remarks></remarks>
            public class IsNotify
            {
                /// <summary>
                /// 未通知
                /// </summary>
                public const string IsNotifyA = "01";
                /// <summary>
                /// 已通知
                /// </summary>
                public const string IsNotifyB = "02";
            }

            /// <summary>
            /// 入职状态.
            /// </summary>
            /// <remarks></remarks>
            public class EntryState
            {
                /// <summary>
                /// 未入职
                /// </summary>
                public const string EntryState01 = "01";
                /// <summary>
                /// 已入职
                /// </summary>
                public const string EntryState02 = "02";
            }
            /// <summary>
            /// 合同签署.
            /// </summary>
            public class IntentSubscription
            {
                /// <summary>
                /// 已签署
                /// </summary>
                public const string IntentSubscriptionA = "01";
                /// <summary>
                /// 未签署
                /// </summary>
                public const string IntentSubscriptionB = "02";
            }

            /// <summary>
            /// 异动评价状态.
            /// </summary>
            public class RegularVendorState
            {
                /// <summary>
                ///  未评价
                /// </summary>
                public const string RegularVendorStateA = "01";
                /// <summary>
                /// 已评价
                /// </summary>
                public const string RegularVendorStateB = "02";
            }

            /// <summary>
            /// 体系分类.
            /// </summary>
            public class FunctionsType
            {
                /// <summary>
                /// 业务
                /// </summary>
                public const string FunctionsTypeA = "05";
                /// <summary>
                /// 职能
                /// </summary>
                public const string FunctionsTypeB = "06";
                /// <summary>
                /// 外协
                /// </summary>
                public const string FunctionsTypeC = "07";
            }

            /// <summary>
            /// 评价设定状态.
            /// </summary>
            public class VendorGoalStatus
            {
                /// <summary>
                /// 未设定
                /// </summary>
                public const string VendorGoalStatusA = "01";
                /// <summary>
                /// 已设定
                /// </summary>
                public const string VendorGoalStatusB = "02";
            }

            /// <summary>
            /// 联络结果.
            /// </summary>
            public class ContractResult
            {
                /// <summary>
                /// 同意推荐
                /// </summary>
                public const string ContractResultA = "01";
                /// <summary>
                /// 拒绝推荐
                /// </summary>
                public const string ContractResultB = "02";
            }

            /// <summary>
            /// 异动状态.
            /// </summary>
            public class RegularState
            {
                /// <summary>
                /// 待异动
                /// </summary>
                public const string ToStayRegular = "01";
                /// <summary>
                /// 异动中
                /// </summary>
                public const string TheStayRegular = "02";
                /// <summary>
                /// 已异动
                /// </summary>
                public const string AlreadyRegular = "03";
            }

            /// <summary>
            /// 职位类型.
            /// </summary>
            public class StationType
            {
                /// <summary>
                /// 职位
                /// </summary>
                public const string StationTypeA = "01";
                /// <summary>
                /// 职务
                /// </summary>
                public const string StationTypeB = "02";
                /// <summary>
                /// 特殊岗位
                /// </summary>
                public const string StationTypeC = "03";
            }

            /// <summary>
            /// 删除标志.
            /// </summary>
            public class DeleteFlag
            {
                /// <summary>
                /// 有效
                /// </summary>
                public const string DeleteFlagA = "00";
                /// <summary>
                /// 无效
                /// </summary>
                public const string DeleteFlagB = "01";
            }

            /// <summary>
            /// 审批状态.
            /// </summary>
            public class ApplyState
            {
                /// <summary>
                /// 启动申请
                /// </summary>
                public const string ApplyStart = "06";
                /// <summary>
                /// 撤销申请
                /// </summary>
                public const string ApplyBack = "07";
                /// <summary>
                /// 审批中
                /// </summary>
                public const string Applying = "08";
                /// <summary>
                /// 审批驳回
                /// </summary>
                public const string ApplyNG = "09";
                /// <summary>
                /// 审批通过
                /// </summary>
                public const string ApplyOK = "10";
                /// <summary>
                /// 填报中
                /// </summary>
                public const string ApplyNoStart = "11";
                /// <summary>
                /// 重新填报中
                /// </summary>
                public const string ApplyReplay = "12";
            }


            /// <summary>
            /// 确认状态
            /// </summary>
            public class ConfirmState
            {
                /// <summary>
                /// 未确认
                /// </summary>
                public const string ConfirmStateA = "01";
                /// <summary>
                /// 已驳回
                /// </summary>
                public const string ConfirmStateB = "02";
                /// <summary>
                /// 已确认
                /// </summary>
                public const string ConfirmStateC = "03";
            }

            /// <summary>
            /// 指标类型
            /// </summary>
            public class IndicatorAType
            {
                /// <summary>
                /// 业绩绩效
                /// </summary>
                public const string IndicatorAA = "01";
                /// <summary>
                /// 能力绩效
                /// </summary>
                public const string IndicatorAB = "02";
                /// <summary>
                /// 态度绩效
                /// </summary>
                public const string IndicatorAC = "03";
            }

            /// <summary>
            /// 指标区分
            /// </summary>
            public class IndicatorKind
            {
                /// <summary>
                /// 定量
                /// </summary>
                public const string IndicatorKindA = "01";
                /// <summary>
                /// 定性
                /// </summary>
                public const string IndicatorKindB = "02";
            }

            /// <summary>
            /// 考核评级
            /// </summary>
            public class PEGrade
            {
                /// <summary>
                /// 卓越
                /// </summary>
                public const string PEGradeA = "01";
                /// <summary>
                /// 优秀
                /// </summary>
                public const string PEGradeB = "02";
                /// <summary>
                /// 胜任
                /// </summary>
                public const string PEGradeC = "03";
                /// <summary>
                /// 需改进
                /// </summary>
                public const string PEGradeD = "04";
                /// <summary>
                /// 差
                /// </summary>
                public const string PEGradeE = "05";
            }

            /// <summary>
            /// 面试评价等级
            /// </summary>
            public class InterviewScroe
            {
                /// <summary>
                /// 1
                /// </summary>
                public const string InterviewScroeA = "01";
                /// <summary>
                /// 2
                /// </summary>
                public const string InterviewScroeB = "02";
                /// <summary>
                /// 3
                /// </summary>
                public const string InterviewScroeC = "03";
                /// <summary>
                /// 4
                /// </summary>
                public const string InterviewScroeD = "04";
                /// <summary>
                /// 5
                /// </summary>
                public const string InterviewScroeE = "05";
            }

            /// <summary>
            /// 考核阶段
            /// </summary>
            public class PEPhase
            {
                /// <summary>
                /// 目标设定
                /// </summary>
                public const string PEPhaseA = "01";
                /// <summary>
                /// 考核实施
                /// </summary>
                public const string PEPhaseB = "02";
            }

            /// <summary>
            /// 考核活动状态.
            /// </summary>
            /// <remarks></remarks>
            public class PEActionStatus
            {
                /// <summary>
                /// 未启动
                /// </summary>
                public const string PEActionStatusNotStart = "01";
                /// <summary>
                /// 已启动
                /// </summary>
                public const string PEActionStatusAlreadyStart = "02";
                /// <summary>
                /// 已结束
                /// </summary>
                public const string PEActionStatusIsOver = "03";
            }

            /// <summary>
            /// 组织级别.
            /// </summary>
            /// <remarks></remarks>
            public class OrgLevel
            {
                /// <summary>
                /// 集团级
                /// </summary>
                public const string OrgLevelGroup = "07";
                /// <summary>
                /// 公司级
                /// </summary>
                public const string OrgLevelCompany = "08";
                /// <summary>
                /// 业务集团级
                /// </summary>
                public const string OrgLevelBusinessGroup = "09";
                /// <summary>
                /// 事业部级
                /// </summary>
                public const string OrgLevelDivision = "10";
                /// <summary>
                /// 中心级
                /// </summary>
                public const string OrgLevelCenter = "11";
                /// <summary>
                /// 部门级
                /// </summary>
                public const string OrgLevelDepartment = "12";
            }

            /// <summary>
            /// 考核类型.
            /// </summary>
            /// <remarks></remarks>
            public class PEType
            {
                /// <summary>
                /// 见习期考核
                /// </summary>
                public const string PETypeNovitiate = "01";
                /// <summary>
                /// 实习期考核
                /// </summary>
                public const string PETypePractice = "02";
                /// <summary>
                /// 试用期考核
                /// </summary>
                public const string PETypeTryOut = "03";
                /// <summary>
                /// 绩效考核
                /// </summary>
                public const string PETypePerformance = "04";
                /// <summary>
                /// 外聘考核
                /// </summary>
                public const string PETypeEmPloy = "05";
                /// <summary>
                /// 供应商考核
                /// </summary>
                public const string PETypeSupplier = "06";
                /// <summary>
                /// 面试考核
                /// </summary>
                public const string PETypeInterview = "07";
            }

            /// <summary>
            /// 目标设定状态.
            /// </summary>
            /// <remarks></remarks>
            public class PEGoalStatus
            {
                /// <summary>
                /// 未设定
                /// </summary>
                public const string PEGoalStatus01 = "01";
                /// <summary>
                /// 设定中
                /// </summary>
                public const string PEGoalStatus02 = "02";
                /// <summary>
                /// 未承认
                /// </summary>
                public const string PEGoalStatus03 = "03";
                /// <summary>
                /// 承认中
                /// </summary>
                public const string PEGoalStatus04 = "04";
                /// <summary>
                /// 未审核
                /// </summary>
                public const string PEGoalStatus05 = "05";
                /// <summary>
                /// 审核通过
                /// </summary>
                public const string PEGoalStatus06 = "06";
                /// <summary>
                /// 审核驳回
                /// </summary>
                public const string PEGoalStatus07 = "07";
                /// <summary>
                /// 指标未设定.   --PCMM流程
                /// </summary>
                public const string PEGoalStatus08 = "08";
                /// <summary>
                /// 指标设定中.   --PCMM流程
                /// </summary>
                public const string PEGoalStatus09 = "09";
                /// <summary>
                /// 目标未设定.   --PCMM流程
                /// </summary>
                public const string PEGoalStatus10 = "10";
                /// <summary>
                /// 目标设定中.   --PCMM流程
                /// </summary>
                public const string PEGoalStatus11 = "11";
                /// <summary>
                /// 目标未确认.   --PCMM流程
                /// </summary>
                public const string PEGoalStatus12 = "12";
                /// <summary>
                /// 目标驳回.     --PCMM流程
                /// </summary>
                public const string PEGoalStatus13 = "13";
            }
            /// <summary>
            /// 目标设定状态.
            /// </summary>
            /// <remarks></remarks>
            public class CheckPCMM
            {
                /// <summary>
                /// 是PCMM流程组织
                /// </summary>
                public const string CheckPCMM_True = "01";
                /// <summary>
                /// 不是PCMM流程组织
                /// </summary>
                public const string CheckPCMM_False = "02";
            }


            /// <summary>
            /// 考核状态.
            /// </summary>
            /// <remarks></remarks>
            public class PEEvaluateStatus
            {
                /// <summary>
                /// 未自评
                /// </summary>
                public const string PEEvaluateStatus01 = "01";
                /// <summary>
                /// 自评中
                /// </summary>
                public const string PEEvaluateStatus02 = "02";
                /// <summary>
                /// 未考核
                /// </summary>
                public const string PEEvaluateStatus03 = "03";
                /// <summary>
                /// 考核中
                /// </summary>
                public const string PEEvaluateStatus04 = "04";
                /// <summary>
                /// 未审核
                /// </summary>
                public const string PEEvaluateStatus05 = "05";
                /// <summary>
                /// 审核通过
                /// </summary>
                public const string PEEvaluateStatus06 = "06";
                /// <summary>
                /// 审核驳回
                /// </summary>
                public const string PEEvaluateStatus07 = "07";
                /// <summary>
                /// 本人已承诺
                /// </summary>
                public const string PEEvaluateStatus08 = "08";
                /// <summary>
                /// 本人已拒绝
                /// </summary>
                public const string PEEvaluateStatus09 = "09";
                /// <summary>
                /// 事业部审核通过
                /// </summary>
                public const string PEEvaluateStatus10 = "10";
                /// <summary>
                /// 事业部审核驳回
                /// </summary>
                public const string PEEvaluateStatus11 = "11";
                /// <summary>
                /// 公司审核通过
                /// </summary>
                public const string PEEvaluateStatus12 = "12";
                /// <summary>
                /// 公司审核驳回
                /// </summary>
                public const string PEEvaluateStatus13 = "13";
                /// <summary>
                /// 本人已申诉
                /// </summary>
                public const string PEEvaluateStatus14 = "14";

            }


            /// <summary>
            /// 人才状态.
            /// </summary>
            /// <remarks></remarks>
            public class LeaveEnjoyFlg
            {
                /// <summary>
                /// 共享
                /// </summary>
                public const string LeaveEnjoyFlg00 = "00";
                /// <summary>
                /// 不共享
                /// </summary>
                public const string LeaveEnjoyFlg01 = "01";
            }



            /// <summary>
            /// 离职共享邮件发送状态.
            /// </summary>
            /// <remarks></remarks>
            public class LeaveEmailFlg
            {
                /// <summary>
                /// 未发送
                /// </summary>
                public const string LeaveEmailFlg00 = "00";
                /// <summary>
                /// 已发送
                /// </summary>
                public const string LeaveEmailFlg01 = "01";
            }


            /// <summary>
            /// 人才状态.
            /// </summary>
            /// <remarks></remarks>
            public class WorkState
            {
                /// <summary>
                /// 新人才
                /// </summary>
                public const string WorkState01 = "07";
                /// <summary>
                /// 流程中
                /// </summary>
                public const string WorkState02 = "08";
                /// <summary>
                /// 待入职
                /// </summary>
                public const string WorkState03 = "09";
                /// <summary>
                /// 入职
                /// </summary>
                public const string WorkState04 = "10";
                /// <summary>
                /// 离职
                /// </summary>
                public const string WorkState05 = "11";
                /// <summary>
                /// 淘汰
                /// </summary>
                public const string WorkState06 = "12";
                /// <summary>
                /// 拒绝
                /// </summary>
                public const string WorkState07 = "13";
                /// <summary>
                /// 违约
                /// </summary>
                public const string WorkState08 = "14";
            }


            /// <summary>
            /// 受理模式.
            /// </summary>
            /// <remarks></remarks>
            public class AcceptMode
            {
                /// <summary>
                /// 手动受理
                /// </summary>
                public const string AcceptMode00 = "00";
                /// <summary>
                /// 自动受理
                /// </summary>
                public const string AcceptMode01 = "01";
            }


            /// <summary>
            /// 需求状态.
            /// </summary>
            /// <remarks></remarks>
            public class RequestState
            {
                /// <summary>
                /// 未提交
                /// </summary>
                public const string NotRefer = "06";
                /// <summary>
                /// 审批中
                /// </summary>
                public const string Requesting = "07";
                /// <summary>
                /// 审批通过
                /// </summary>
                public const string RequestApprove = "08";
                /// <summary>
                /// 审批驳回
                /// </summary>
                public const string RequestReject = "09";
                /// <summary>
                /// 进行中
                /// </summary>
                public const string UnderWay = "10";
                /// <summary>
                /// 暂停
                /// </summary>
                public const string Pause = "11";
                /// <summary>
                /// 结束
                /// </summary>
                public const string Close = "12";
            }

            /// <summary>
            /// 需求共享状态.
            /// </summary>
            /// <remarks></remarks>
            public class RequestShareState
            {
                /// <summary>
                /// 进行中
                /// </summary>
                public const string UnderWay = "01";
                /// <summary>
                /// 结束
                /// </summary>
                public const string Close = "02";
            }

            /// <summary>
            /// 学历.
            /// </summary>
            public class EducationalCode
            {
                /// <summary>
                /// 高中
                /// </summary>
                public const string EducationalCode01 = "01";
                /// <summary>
                /// 中专
                /// </summary>
                public const string EducationalCode02 = "02";
                /// <summary>
                /// 大专
                /// </summary>
                public const string EducationalCode03 = "03";
                /// <summary>
                /// 本科
                /// </summary>
                public const string EducationalCode04 = "04";
                /// <summary>
                /// 硕士
                /// </summary>
                public const string EducationalCode05 = "05";
                /// <summary>
                /// 博士
                /// </summary>
                public const string EducationalCode06 = "06";
                /// <summary>
                /// 其他
                /// </summary>
                public const string EducationalCode07 = "07";
                /// <summary>
                /// MBA,EMBA
                /// </summary>
                public const string EducationalCode08 = "08";
            }

            /// <summary>
            /// Offer接受状态.
            /// </summary>
            /// <remarks></remarks>
            public class OfferReceiveState
            {
                /// <summary>
                /// 拒绝
                /// </summary>
                public const string OfferReceiveState01 = "01";
                /// <summary>
                /// 接受后拒绝
                /// </summary>
                public const string OfferReceiveState02 = "02";
                /// <summary>
                /// 接受
                /// </summary>
                public const string OfferReceiveState03 = "03";
                /// <summary>
                /// 已入职
                /// </summary>
                public const string OfferReceiveState04 = "04";
            }

            /// <summary>
            /// 在职状态.
            /// </summary>
            /// <remarks></remarks>
            public class OfficeState
            {
                /// <summary>
                /// 在职
                /// </summary>
                public const string OfficeState01 = "01";
                /// <summary>
                /// 离职
                /// </summary>
                public const string OfficeState02 = "02";
            }

            /// <summary>
            /// 合同状态.
            /// </summary>
            public class ContractState
            {
                /// <summary>
                /// 有效
                /// </summary>
                public const string ContractState01 = "01";
                /// <summary>
                /// 已终止
                /// </summary>
                public const string ContractState02 = "02";
                /// <summary>
                /// 已解除
                /// </summary>
                public const string ContractState03 = "03";
            }

            /// <summary>
            /// 合同签订状态.
            /// </summary>
            /// <remarks></remarks>
            public class SignStateCode
            {
                /// <summary>
                /// 初签
                /// </summary>
                public const string SignStateCode01 = "01";
                /// <summary>
                /// 变更
                /// </summary>
                public const string SignStateCode02 = "02";
                /// <summary>
                /// 续签
                /// </summary>
                public const string SignStateCode03 = "03";
                /// <summary>
                /// 终止
                /// </summary>
                public const string SignStateCode04 = "04";
                /// <summary>
                /// 解除
                /// </summary>
                public const string SignStateCode05 = "05";
            }


            /// <summary>
            /// 申诉状态.
            /// </summary>
            public class AppealStatus
            {
                /// <summary>
                /// 申诉中
                /// </summary>
                public const string ApplyStart = "01";
                /// <summary>
                /// 申诉通过-重新评价
                /// </summary>
                public const string ApplyBack = "02";
                /// <summary>
                /// 申诉驳回
                /// </summary>
                public const string Applying = "03";
            }

            /// <summary>
            /// 调动状态.
            /// </summary>
            /// <remarks></remarks>
            public class TrunState
            {
                /// <summary>
                /// 调入
                /// </summary>
                public const string TrunState01 = "01";
                /// <summary>
                /// 调出
                /// </summary>
                public const string TrunState02 = "02";
            }


            /// <summary>
            /// 资产种类.导出时使用“勿删”
            /// </summary>
            public class AssetType
            {
                /// <summary>
                /// 组织规程
                /// </summary>
                public const string OrganizationRule = "01";
                /// <summary>
                /// 管理标准
                /// </summary>
                public const string ManageStandard = "02";
                /// <summary>
                /// 开发规约
                /// </summary>
                public const string DevelopmentRules = "03";
                /// <summary>
                /// 工作指南
                /// </summary>
                public const string WorkingGuide = "04";
                /// <summary>
                /// 操作说明
                /// </summary>
                public const string OperationNotes = "05";
                /// <summary>
                /// 文档模板
                /// </summary>
                public const string DocumentTemplet = "06";
                /// <summary>
                /// 实践案例
                /// </summary>
                public const string PractiseCase = "07";
                /// <summary>
                /// 检查单
                /// </summary>
                public const string CheckList = "08";
                /// <summary>
                /// 培训教材
                /// </summary>
                public const string EducationDocument = "09";
                /// <summary>
                /// 支持工具
                /// </summary>
                public const string SupportTool = "10";
                /// <summary>
                /// 附件
                /// </summary>
                public const string Attachment = "11";
                /// <summary>
                /// 其它
                /// </summary>
                public const string Other = "12";
                /// <summary>
                /// 图片
                /// </summary>
                public const string Images = "13";
                /// <summary>
                /// 结算单
                /// </summary>
                public const string DepartFile = "14";
            }

            /// <summary>
            /// 推荐类型.
            /// </summary>
            public class RecommendType
            {
                /// <summary>
                /// 外协推荐
                /// </summary>
                public const string Recommend01 = "01";
                /// <summary>
                /// 员工自荐
                /// </summary>
                public const string Recommend02 = "02";
                /// <summary>
                /// 内部推荐
                /// </summary>
                public const string Recommend03 = "03";
                /// <summary>
                /// 招聘专员推荐
                /// </summary>
                public const string Recommend04 = "04";
            }

            /// <summary>
            /// 档案类型.
            /// </summary>
            public class ArchivesType
            {
                /// <summary>
                /// 人事档案
                /// </summary>
                public const string PersonnelArchives = "01";
                /// <summary>
                /// 业务档案
                /// </summary>
                public const string OperationArchives = "02";
            }

            /// <summary>
            /// 查借方式.
            /// </summary>
            public class BorrowWay
            {
                /// <summary>
                /// 借走整个档案
                /// </summary>
                public const string AllBorrow = "01";
                /// <summary>
                /// 借走部分材料
                /// </summary>
                public const string PartBorrow = "02";
                /// <summary>
                /// 查阅部分材料
                /// </summary>
                public const string ConsultPart = "03";
                /// <summary>
                /// 复印部分材料
                /// </summary>
                public const string CopyPart = "04";
            }

            /// <summary>
            /// 户籍物件类型.
            /// </summary>
            public class CensusType
            {
                /// <summary>
                /// 户籍首页
                /// </summary>
                public const string Census1STPage = "01";
                /// <summary>
                /// 户籍个人页
                /// </summary>
                public const string CensusPersonalPage = "02";
            }

            /// <summary>
            /// 合同期限类型.
            /// </summary>
            public class ContracTermType
            {
                /// <summary>
                /// 有固定期限合同
                /// </summary>
                public const string ChangelessContract = "01";
                /// <summary>
                /// 无固定期限合同
                /// </summary>
                public const string UnchangelessContract = "02";
                /// <summary>
                /// 以完成一定工作任务为期限
                /// </summary>
                public const string TofinishWork = "03";
            }

            /// <summary>
            /// 合同期限.
            /// </summary>
            public class ContractDeadineType
            {
                /// <summary>
                /// 1年
                /// </summary>
                public const string ContractDeadineTypeA = "06";
                /// <summary>
                /// 2年
                /// </summary>
                public const string ContractDeadineTypeB = "07";
                /// <summary>
                /// 3年
                /// </summary>
                public const string ContractDeadineTypeC = "08";
                /// <summary>
                /// 4年
                /// </summary>
                public const string ContractDeadineTypeD = "09";
                /// <summary>
                /// 无固定期限
                /// </summary>
                public const string ContractDeadineTypeE = "11";
                /// <summary>
                ///     5年
                /// </summary>
                public const string ContractDeadineTypeF = "10";
            }

            /// <summary>
            /// 借用状态.
            /// </summary>
            public class BorState
            {
                /// <summary>
                /// 未领取
                /// </summary>
                public const string NotDraw = "04";
                /// <summary>
                /// 未到期
                /// </summary>
                public const string NotAtTerm = "05";
                /// <summary>
                /// 丢失
                /// </summary>
                public const string miss = "06";
                /// <summary>
                /// 已归还
                /// </summary>
                public const string Returned = "07";
                /// <summary>
                /// 到期未归还
                /// </summary>
                public const string NotReturnAtTerm = "08";
            }


            /// <summary>
            /// 借出状态.
            /// </summary>
            public class BorOutState
            {
                /// <summary>
                /// 未领取
                /// </summary>
                public const string NotDraw = "01";
                /// <summary>
                /// 使用中
                /// </summary>
                public const string Useing = "02";
                /// <summary>
                /// 丢失
                /// </summary>
                public const string Miss = "03";
                /// <summary>
                /// 已归还
                /// </summary>
                public const string Returned = "04";
                /// <summary>
                /// 预借用
                /// </summary>
                public const string LineUp = "05";
            }

            /// <summary>
            /// 邮箱状态.
            /// </summary>
            public class MailState
            {
                /// <summary>
                /// 有效
                /// </summary>
                public const string Efficiency = "01";
                /// <summary>
                /// 无效
                /// </summary>
                public const string Inefficacy = "02";
            }

            /// <summary>
            /// 受理状态.
            /// </summary>
            public class AcceptState
            {
                /// <summary>
                /// 已受理
                /// </summary>
                public const string Accepted = "01";
                /// <summary>
                /// 未受理
                /// </summary>
                public const string Disaceped = "02";
            }

            /// <summary>
            /// 员工类别.
            /// </summary>
            /// <remarks></remarks>
            public class StaffType
            {
                /// <summary>
                /// 正式
                /// </summary>
                public const string Formal = "01";
                /// <summary>
                /// 试用
                /// </summary>
                public const string Probation = "02";
                /// <summary>
                /// 实习
                /// </summary>
                public const string Practice = "03";
                /// <summary>
                /// 见习
                /// </summary>
                public const string Noviciate = "08";
                /// <summary>
                /// 外协
                /// </summary>
                public const string Cooperate = "09";
                /// <summary>
                /// 外聘
                /// </summary>
                public const string Other = "10";
                /// <summary>
                /// 劳务
                /// </summary>
                public const string OutRetain = "11";
                /// <summary>
                /// 其他
                /// </summary>
                public const string Labour = "12";
            }


            /// <summary>
            /// 异动种类.
            /// </summary>
            /// <remarks></remarks>
            public class RegularType
            {
                /// <summary>
                /// 入职
                /// </summary>
                public const string Work = "01";
                /// <summary>
                /// 延长见习期
                /// </summary>
                public const string ExtendNoviciate = "02";
                /// <summary>
                /// 转实习
                /// </summary>
                public const string TurnToPractice = "03";
                /// <summary>
                /// 延长实习期
                /// </summary>
                public const string ExtendPractice = "04";
                /// <summary>
                /// 转试用
                /// </summary>
                public const string TurnToProbation = "05";
                /// <summary>
                /// 延长试用
                /// </summary>
                public const string ExtendProbation = "06";
                /// <summary>
                /// 转正式
                /// </summary>
                public const string TurnToFormal = "07";
                /// <summary>
                /// 内部调转
                /// </summary>
                public const string InsideTranfer = "08";
                /// <summary>
                /// 内部借用
                /// </summary>
                public const string InsideBorrow = "09";
                /// <summary>
                /// 职位变动
                /// </summary>
                public const string PositionChange = "10";
                /// <summary>
                /// 职务变动
                /// </summary>
                public const string DutyChange = "11";
                /// <summary>
                /// 离职
                /// </summary>
                public const string Dimission = "12";
                /// <summary>
                /// 终止雇佣
                /// </summary>
                public const string RegularType13 = "13";
            }

            /// <summary>
            /// 户籍调动状态.
            /// </summary>
            public class CensusState
            {
                /// <summary>
                /// 迁入
                /// </summary>
                public const string InGoing = "01";
                /// <summary>
                /// 迁出
                /// </summary>
                public const string OutGoing = "02";
            }

            /// <summary>
            /// 证件类型.
            /// </summary>
            public class CertificateType
            {
                /// <summary>
                /// 身份证
                /// </summary>
                public const string IDCard = "01";
                /// <summary>
                /// 居民证
                /// </summary>
                public const string DenizenCard = "02";
                /// <summary>
                /// 护照
                /// </summary>
                public const string PassCard = "03";
            }

            ///<summary>
            /// 出国申请类型.
            /// </summary>
            public class TGAResType
            {
                /// <summary>
                /// 开发人员
                /// </summary>
                public const string TGAResTypeA = "01";
                /// <summary>
                /// 商务/事务人员
                /// </summary>
                public const string TGAResTypeB = "02";
                /// <summary>
                /// 商务/事务人员
                /// </summary>
                public const string TGAResTypeC = "03";
            }

            /// <summary>
            /// 签证区分.
            /// </summary>
            public class VisaStyle
            {
                /// <summary>
                /// 短期商务
                /// </summary>
                public const string VisaStyleA = "01";
                /// <summary>
                /// 长期签证
                /// </summary>
                public const string VisaStyleB = "02";
            }

            /// <summary>
            /// 新签证类型.
            /// </summary>
            public class VisaTypeNew
            {
                /// <summary>
                /// 短期商务
                /// </summary>
                public const string VisaTypeNewA = "01";
                /// <summary>
                /// 企业内转勤
                /// </summary>
                public const string VisaTypeNewC = "03";
                /// <summary>
                /// 技术
                /// </summary>
                public const string VisaTypeNewE = "05";
                /// <summary>
                /// 研修
                /// </summary>
                public const string VisaTypeNewF = "06";
            }

            /// <summary>
            /// 签证期间.
            /// </summary>
            public class VisaPeriod
            {
                /// <summary>
                /// 15天
                /// </summary>
                public const string VisaPeriod1 = "01";
                /// <summary>
                /// 30天
                /// </summary>
                public const string VisaPeriod2 = "02";
                /// <summary>
                /// 90天
                /// </summary>
                public const string VisaPeriod3 = "03";
                /// <summary>
                /// 半年
                /// </summary>
                public const string VisaPeriod4 = "04";
                /// <summary>
                /// 一年
                /// </summary>
                public const string VisaPeriod5 = "05";
                /// <summary>
                /// 一年以上
                /// </summary>
                public const string VisaPeriod6 = "06";
                /// <summary>
                /// 一年多次
                /// </summary>
                public const string VisaPeriod7 = "07";
                /// <summary>
                /// 一年多次
                /// </summary>
                public const string VisaPeriod8 = "08";
                /// <summary>
                /// 三年多次
                /// </summary>
                public const string VisaPeriod9 = "09";
                /// <summary>
                /// 永驻
                /// </summary>
                public const string VisaPeriod10 = "10";
                /// <summary>
                /// 三年
                /// </summary>
                public const string VisaPeriod11 = "11";
                /// <summary>
                /// 五年
                /// </summary>
                public const string VisaPeriod12 = "12";
            }

            /// <summary>
            /// DHC转籍JHC协议签订状态.
            /// </summary>
            /// <remarks></remarks>
            public class IsDHCFlag
            {
                /// <summary>
                /// 已签订
                /// </summary>
                public const string IsDHCFlagTrue = "01";
                /// <summary>
                /// 未签订
                /// </summary>
                public const string IsDHCFlagFalse = "02";
            }

            /// <summary>
            /// 签证类型.
            /// </summary>
            public class VisaType
            {
                /// <summary>
                /// 研修
                /// </summary>
                public const string VisaTypeA = "01";
                /// <summary>
                /// POTS
                /// </summary>
                public const string VisaTypeB = "02";
                /// <summary>
                /// 企业内执勤
                /// </summary>
                public const string VisaTypeC = "03";
                /// <summary>
                /// 人文
                /// </summary>
                public const string VisaTypeD = "04";
                /// <summary>
                /// 技术（JHC转籍）
                /// </summary>
                public const string VisaTypeE = "05";
            }


            /// <summary>
            /// 合同是否续签.
            /// </summary>
            public class ReSignCompactFlg
            {
                /// <summary>
                /// 续签
                /// </summary>
                public const string ReSignCompactFlgA = "01";
                /// <summary>
                /// 不续签
                /// </summary>
                public const string ReSignCompactFlgB = "02";
            }

            /// <summary>
            /// 人才分类.
            /// </summary>
            public class TalentIType
            {
                /// <summary>
                /// 应届人才
                /// </summary>
                public const string TalentITypeA = "01";
                /// <summary>
                /// 社会人才
                /// </summary>
                public const string TalentITypeB = "02";
                /// <summary>
                /// 外协人才
                /// </summary>
                public const string TalentITypeC = "03";
            }

            /// <summary>
            /// 黑名单.
            /// </summary>
            public class IsBlackList
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string IsBlackListA = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string IsBlackListB = "02";
            }

            /// <summary>
            /// 签证办理状态.
            /// </summary>
            public class VisaTransactState
            {
                /// <summary>
                /// 未申请
                /// </summary>
                public const string VisaTransactStateA = "01";
                /// <summary>
                /// 申请中
                /// </summary>
                public const string VisaTransactStateB = "02";
                /// <summary>
                /// 保留中
                /// </summary>
                public const string VisaTransactStateC = "03";
                /// <summary>
                /// 拒签
                /// </summary>
                public const string VisaTransactStateD = "04";
                /// <summary>
                /// 正常签发
                /// </summary>
                public const string VisaTransactStateE = "05";
                /// <summary>
                /// 保留后签发
                /// </summary>
                public const string VisaTransactStateF = "06";
            }

            /// <summary>
            /// 影响标志.
            /// </summary>
            public class EffactFlag
            {
                /// <summary>
                /// 一般
                /// </summary>
                public const string EffactFlagA = "01";
                /// <summary>
                /// 重要
                /// </summary>
                public const string EffactFlagB = "02";
            }

            /// <summary>
            /// 离职原因.
            /// </summary>
            public class LeaveOfficeCause
            {
                /// <summary>
                /// 岗位变动
                /// </summary>
                public const string LeaveOfficeCauseA = "01";
                /// <summary>
                /// 家庭
                /// </summary>
                public const string LeaveOfficeCauseB = "02";
                /// <summary>
                /// 劳动强度/工作压力
                /// </summary>
                public const string LeaveOfficeCauseC = "03";
                /// <summary>
                /// 工作环境/工作氛围
                /// </summary>
                public const string LeaveOfficeCauseD = "04";
                /// <summary>
                /// 工作内容单调
                /// </summary>
                public const string LeaveOfficeCauseE = "05";
                /// <summary>
                /// 再教育
                /// </summary>
                public const string LeaveOfficeCauseF = "06";
                /// <summary>
                /// 薪酬福利
                /// </summary>
                public const string LeaveOfficeCauseG = "07";
                /// <summary>
                /// 寻找更好的发展机会
                /// </summary>
                public const string LeaveOfficeCauseH = "08";
                /// <summary>
                /// 业务稳定性
                /// </summary>
                public const string LeaveOfficeCauseI = "09";
                /// <summary>
                /// 违纪
                /// </summary>
                public const string LeaveOfficeCauseJ = "10";
                /// <summary>
                /// 业务/技能
                /// </summary>
                public const string LeaveOfficeCauseK = "11";
                /// <summary>
                /// 擅自离职
                /// </summary>
                public const string LeaveOfficeCauseL = "12";
                /// <summary>
                /// 调转JHC
                /// </summary>
                public const string LeaveOfficeCauseM = "13";
                /// <summary>
                /// 单位外聘
                /// </summary>
                public const string LeaveOfficeCauseN = "14";
                /// <summary>
                /// 生活/工作平衡
                /// </summary>
                public const string LeaveOfficeCauseO = "15";
                /// <summary>
                /// 缺乏认可/绩效评价
                /// </summary>
                public const string LeaveOfficeCauseP = "16";
                /// <summary>
                /// 制度/流程不认可
                /// </summary>
                public const string LeaveOfficeCauseQ = "17";
                /// <summary>
                /// 身体原因需要休养
                /// </summary>
                public const string LeaveOfficeCauseR = "18";
                /// <summary>
                /// 工作安排（倒班、派遣等）不满意
                /// </summary>
                public const string LeaveOfficeCauseS = "19";
                /// <summary>
                /// 改行/创业
                /// </summary>
                public const string LeaveOfficeCauseT = "20";
                /// <summary>
                /// 出国
                /// </summary>
                public const string LeaveOfficeCauseU = "21";
                /// <summary>
                /// 公务员/国企
                /// </summary>
                public const string LeaveOfficeCauseV = "22";
                /// <summary>
                /// 其他
                /// </summary>
                public const string LeaveOfficeCauseW = "23";
                /// <summary>
                /// 办公地点变化
                /// </summary>
                public const string LeaveOfficeCause24 = "24";
                /// <summary>
                /// 长期出差对生活影响较大
                /// </summary>
                public const string LeaveOfficeCause25 = "25";
                /// <summary>
                /// 对目前工作失去兴趣
                /// </summary>
                public const string LeaveOfficeCause26 = "26";
                /// <summary>
                /// 移居其他城市发展
                /// </summary>
                public const string LeaveOfficeCause27 = "27";
                /// <summary>
                /// 回老家工作
                /// </summary>
                public const string LeaveOfficeCause28 = "28";
                /// <summary>
                /// 家庭成员强烈要求
                /// </summary>
                public const string LeaveOfficeCause29 = "29";
                /// <summary>
                /// 不适应本行业工作方式
                /// </summary>
                public const string LeaveOfficeCause30 = "30";
                /// <summary>
                /// 人际关系处理不好
                /// </summary>
                public const string LeaveOfficeCause31 = "31";
                /// <summary>
                /// 试用期淘汰
                /// </summary>
                public const string LeaveOfficeCause32 = "32";
                /// <summary>
                /// 合同到期
                /// </summary>
                public const string LeaveOfficeCause33 = "33";
            }

            /// <summary>
            /// 申请类型.
            /// </summary>
            public class ReserveType
            {
                /// <summary>
                /// 转实习申请
                /// </summary>
                public const string ReserveTypeA = "01";
                /// <summary>
                /// 转试用申请
                /// </summary>
                public const string ReserveTypeB = "02";
                /// <summary>
                /// 转正申请
                /// </summary>
                public const string ReserveTypeC = "03";
                /// <summary>
                /// 合同续签申请
                /// </summary>
                public const string ReserveTypeD = "04";
                /// <summary>
                /// 内部调动申请
                /// </summary>
                public const string ReserveTypeE = "05";
                /// <summary>
                /// 调动交接申请
                /// </summary>
                public const string ReserveTypeF = "06";
                /// <summary>
                /// 离职申请
                /// </summary>
                public const string ReserveTypeG = "07";
                /// <summary>
                /// 离职交接申请
                /// </summary>
                public const string ReserveTypeH = "08";
                /// <summary>
                /// 出国申请
                /// </summary>
                public const string ReserveTypeI = "09";
                /// <summary>
                /// 出国准备申请
                /// </summary>
                public const string ReserveTypeJ = "10";
                /// <summary>
                /// 机票申请
                /// </summary>
                public const string ReserveTypeK = "11";
                /// <summary>
                /// 保险申请
                /// </summary>
                public const string ReserveTypeL = "12";
                /// <summary>
                /// 出国工作总结申请
                /// </summary>
                public const string ReserveTypeM = "13";
                /// <summary>
                /// 邮箱申请
                /// </summary>
                public const string ReserveTypeN = "14";
                /// <summary>
                /// 档案借用申请
                /// </summary>
                public const string ReserveTypeO = "15";
            }

            /// <summary>
            /// 保险状态.
            /// </summary>
            public class InsuranceState
            {
                /// <summary>
                /// 初保
                /// </summary>
                public const string InsuranceStateA = "01";
                /// <summary>
                /// 续保
                /// </summary>
                public const string InsuranceStateB = "02";
            }

            /// <summary>
            /// 外事状态.
            /// </summary>
            public class ICFAState
            {
                /// <summary>
                /// 出国申请已提交
                /// </summary>
                public const string ICFAStateA = "01";
                /// <summary>
                /// 出国申请审批中
                /// </summary>
                public const string ICFAStateB = "02";
                /// <summary>
                /// 出国申请已撤销
                /// </summary>
                public const string ICFAStateC = "03";
                /// <summary>
                /// 出国申请被驳回
                /// </summary>
                public const string ICFAStateD = "04";
                /// <summary>
                /// 出国申请已通过
                /// </summary>
                public const string ICFAStateE = "05";
                /// <summary>
                /// 保险机票申请中
                /// </summary>
                public const string ICFAStateF = "06";
                /// <summary>
                /// 出国工作准备中
                /// </summary>
                public const string ICFAStateG = "07";
                /// <summary>
                /// 出国准备已完了
                /// </summary>
                public const string ICFAStateH = "08";
                /// <summary>
                /// 出国中
                /// </summary>
                public const string ICFAStateI = "09";
                /// <summary>
                /// 归国
                /// </summary>
                public const string ICFAStateJ = "10";
                /// <summary>
                /// 出国总结已提交
                /// </summary>
                public const string ICFAStateK = "11";
                /// <summary>
                /// 结束
                /// </summary>
                public const string ICFAStateL = "12";
            }


            /// <summary>
            /// 机票状态.
            /// </summary>
            public class AirticketStatus
            {
                /// <summary>
                /// 未预订
                /// </summary>
                public const string AirticketStatusA = "01";
                /// <summary>
                /// 已预订
                /// </summary>
                public const string AirticketStatusB = "02";
                /// <summary>
                /// 已出票
                /// </summary>
                public const string AirticketStatusC = "03";
            }

            /// <summary>
            /// 保险申请状态.
            /// </summary>
            public class InsuranceReserveState
            {
                /// <summary>
                /// 未申请
                /// </summary>
                public const string InsuranceReserveStateA = "01";
                /// <summary>
                /// 已申请
                /// </summary>
                public const string InsuranceReserveStateB = "02";
                /// <summary>
                /// 已投保
                /// </summary>
                public const string InsuranceReserveStateC = "03";
            }


            /// <summary>
            /// 职位等级.
            /// </summary>
            public class EmployLevel
            {
                /// <summary>
                /// 1级
                /// </summary>
                public const string EmployLevelA = "01";
                /// <summary>
                /// 2级
                /// </summary>
                public const string EmployLevelB = "02";
                /// <summary>
                /// 3级
                /// </summary>
                public const string EmployLevelC = "03";
                /// <summary>
                /// 4级
                /// </summary>
                public const string EmployLevelD = "04";
                /// <summary>
                /// 5级
                /// </summary>
                public const string EmployLevelE = "05";
                /// <summary>
                /// 6级
                /// </summary>
                public const string EmployLevelF = "06";
                /// <summary>
                /// 7级
                /// </summary>
                public const string EmployLevelG = "07";
                /// <summary>
                /// 8级
                /// </summary>
                public const string EmployLevelH = "08";
                /// <summary>
                /// 9级
                /// </summary>
                public const string EmployLevelI = "09";
                /// <summary>
                /// 10级
                /// </summary>
                public const string EmployLevelJ = "10";
                /// <summary>
                /// 11级
                /// </summary>
                public const string EmployLevelK = "11";
                /// <summary>
                /// 12级
                /// </summary>
                public const string EmployLevelL = "12";
                /// <summary>
                /// 13级
                /// </summary>
                public const string EmployLevelM = "13";
                /// <summary>
                /// 14级
                /// </summary>
                public const string EmployLevelN = "14";
                /// <summary>
                /// 15级
                /// </summary>
                public const string EmployLevelO = "15";
                /// <summary>
                /// 16级
                /// </summary>
                public const string EmployLevelP = "16";
            }

            /// <summary>
            /// 外语种类.
            /// </summary>
            public class LanguageType
            {
                /// <summary>
                /// 英语
                /// </summary>
                public const string LanguageTypeA = "01";
                /// <summary>
                /// 日语
                /// </summary>
                public const string LanguageTypeB = "02";
                /// <summary>
                /// 朝鲜语
                /// </summary>
                public const string LanguageTypeC = "03";
                /// <summary>
                /// 其他.
                /// </summary>
                public const string LanguageTypeD = "04";
            }

            /// <summary>
            /// 招聘类型.
            /// </summary>
            public class RecruitType
            {
                /// <summary>
                /// 内部招聘
                /// </summary>
                public const string RecruitTypeA = "01";
                /// <summary>
                /// 外部招聘
                /// </summary>
                public const string RecruitTypeB = "02";
                /// <summary>
                /// 内外均可
                /// </summary>
                public const string RecruitTypeC = "03";
                /// <summary>
                /// DHEE招聘
                /// </summary>
                public const string RecruitTypeD = "04";
                /// <summary>
                /// DHES招聘
                /// </summary>
                public const string RecruitTypeE = "05";
            }

            /// <summary>
            /// 性别.
            /// </summary>
            public class SexCode
            {
                /// <summary>
                /// 男
                /// </summary>
                public const string SexCodeA = "01";
                /// <summary>
                /// 女
                /// </summary>
                public const string SexCodeB = "02";
            }

            /// <summary>
            /// 面试安排状态.画面使用
            /// </summary>
            public class InterviewState
            {
                /// <summary>
                /// 未安排
                /// </summary>
                public const string InterviewStateA = "01";
                /// <summary>
                /// 已安排
                /// </summary>
                public const string InterviewStateB = "02";
                /// <summary>
                /// 全部
                /// </summary>
                public const string InterviewStateC = "03";
            }
            /// <summary>
            /// 证书类型
            /// </summary>

            public class CredentialsType
            {
                /// <summary>
                /// 技术类
                /// </summary>
                public const string CredentialsTypeA = "01";
                /// <summary>
                /// 语言类
                /// </summary>
                public const string CredentialsTypeB = "02";
                /// <summary>
                /// 管理类
                /// </summary>
                public const string CredentialsTypeC = "03";
                /// <summary>
                /// CMMI
                /// </summary>
                public const string CredentialsTypeD = "04";
            }

            /// <summary>
            /// 定制学校
            /// </summary>
            public class CustoomizationShool
            {
                /// <summary>
                /// 定制
                /// </summary>
                public const string CustoomizationShoolA = "01";
                /// <summary>
                /// 非定制
                /// </summary>
                public const string CustoomizationShoolB = "02";
            }

            /// <summary>
            /// 院校类别
            /// </summary>
            public class UniversityLevel
            {
                /// <summary>
                /// 985院校
                /// </summary>
                public const string UniversityLevelA = "01";
                /// <summary>
                /// 211院校
                /// </summary>
                public const string UniversityLevelB = "02";
                /// <summary>
                /// 一类院校
                /// </summary>
                public const string UniversityLevelC = "03";
                /// <summary>
                /// 二类院校
                /// </summary>
                public const string UniversityLevelD = "04";
                /// <summary>
                /// 三类院校
                /// </summary>
                public const string UniversityLevelE = "05";
                /// <summary>
                /// 专科
                /// </summary>
                public const string UniversityLevelF = "06";
                /// <summary>
                /// 职高
                /// </summary>
                public const string UniversityLevelG = "07";
                /// <summary>
                /// 其他
                /// </summary>
                public const string UniversityLevelH = "08";
            }

            /// <summary>
            /// 是否报到
            /// </summary>
            public class RegisterFlg
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string RegisterFlgA = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string RegisterFlgB = "02";
            }

            /// <summary>
            /// 是否培训
            /// </summary>
            public class TrainFlg
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string TrainFlgA = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string TrainFlgB = "02";
            }

            /// <summary>
            /// 是否违约
            /// </summary>
            public class DefaultFlg
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string DefaultFlgA = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string DefaultFlgB = "02";
            }


            /// <summary>
            /// 核心员工分类
            /// </summary>
            public class CoreStaffType
            {
                /// <summary>
                /// 关键岗位
                /// </summary>
                public const string CoreStaffTypeA = "01";
                /// <summary>
                /// 核心员工
                /// </summary>
                public const string CoreStaffTypeB = "02";
                /// <summary>
                /// 潜力员工
                /// </summary>
                public const string CoreStaffTypeC = "03";
            }
            /// <summary>
            /// 核心员工分类名称
            /// </summary>
            public class CoreStaffTypeName
            {

                public const string CoreStaffTypeNameA = "关键岗位";

                public const string CoreStaffTypeNameB = "核心员工";

                public const string CoreStaffTypeNameC = "潜力员工";
            }

            /// <summary>
            /// 招聘分类
            /// </summary>
            public class Recruitclassify
            {
                /// <summary>
                /// 应届生招聘
                /// </summary>
                public const string RecruitclassifyA = "01";
                /// <summary>
                /// 中途招聘
                /// </summary>
                public const string RecruitclassifyB = "02";
                /// <summary>
                /// 外协招聘
                /// </summary>
                public const string RecruitclassifyC = "03";
            }

            /// <summary>
            /// 招聘批次
            /// </summary>
            public class RecruitLevel
            {
                /// <summary>
                /// 定制班
                /// </summary>
                public const string RecruitLevelA = "01";
                /// <summary>
                /// 一次校招
                /// </summary>
                public const string RecruitLevelB = "02";
                /// <summary>
                /// 二次补招
                /// </summary>
                public const string RecruitLevelC = "03";
            }

            /// <summary>
            /// 通知对象
            /// </summary>
            public class InformationObj
            {
                /// <summary>
                /// 需求提出者
                /// </summary>
                public const string InformationObjA = "01";
                /// <summary>
                /// 面试官
                /// </summary>
                public const string InformationObjB = "02";
                /// <summary>
                /// 事业部HR
                /// </summary>
                public const string InformationGroupHR = "03";
                /// <summary>
                /// 招聘专员
                /// </summary>
                public const string InformationRecruiters = "04";
                /// <summary>
                /// 招聘经理
                /// </summary>
                public const string InformationRecruitManager = "05";
            }

            /// <summary>
            /// 通知方式
            /// </summary>
            public class InformationWay
            {
                /// <summary>
                /// 邮件通知
                /// </summary>
                public const string InformationWayA = "01";
                /// <summary>
                /// 短信通知
                /// </summary>
                public const string InformationWayB = "02";
            }

            /// <summary>
            /// 奖惩区分
            /// </summary>
            public class RewPunFlag
            {
                /// <summary>
                /// 奖励
                /// </summary>
                public const string RewPunFlagA = "01";
                /// <summary>
                /// 惩罚
                /// </summary>
                public const string RewPunFlagB = "02";
            }

            /// <summary>
            /// 需求人才状态
            /// </summary>
            public class RecruitTalentState
            {
                /// <summary>
                /// 待筛选
                /// </summary>
                public const string RecruitTalentStateA = "01";
                /// <summary>
                /// 筛选淘汰
                /// </summary>
                public const string RecruitTalentStateB = "02";
                /// <summary>
                /// 未安排面试
                /// </summary>
                public const string RecruitTalentStateC = "03";
                /// <summary>
                /// 待面试
                /// </summary>
                public const string RecruitTalentStateD = "04";
                /// <summary>
                /// 面试合格
                /// </summary>
                public const string RecruitTalentStateE = "05";
                /// <summary>
                /// 面试淘汰
                /// </summary>
                public const string RecruitTalentStateF = "06";
                /// <summary>
                /// 面试取消
                /// </summary>
                public const string RecruitTalentStateG = "07";
                /// <summary>
                /// 面试结果审核淘汰
                /// </summary>
                public const string RecruitTalentStateH = "08";
                /// <summary>
                /// Offer未发送
                /// </summary>
                public const string RecruitTalentStateI = "09";
                /// <summary>
                /// Offer已发送
                /// </summary>
                public const string RecruitTalentStateJ = "10";
                /// <summary>
                /// 待入职
                /// </summary>
                public const string RecruitTalentStateK = "11";
                /// <summary>
                /// Offer拒绝
                /// </summary>
                public const string RecruitTalentStateL = "12";
                /// <summary>
                /// 信息安全审核淘汰
                /// </summary>
                public const string RecruitTalentStateM = "13";
                /// <summary>
                /// 信息安全审核通过
                /// </summary>
                public const string RecruitTalentStateN = "14";
                /// <summary>
                /// 背景调查审核淘汰
                /// </summary>
                public const string RecruitTalentStateO = "15";
                /// <summary>
                /// 背景调查审核通过
                /// </summary>
                public const string RecruitTalentStateP = "16";
                /// <summary>
                /// 入职
                /// </summary>
                public const string RecruitTalentStateQ = "17";
                /// <summary>
                /// 取消Offer
                /// </summary>
                public const string RecruitTalentStateR = "18";
                /// <summary>
                /// 放弃面试
                /// </summary>
                public const string RecruitTalentStateS = "19";
                /// <summary>
                /// Offer储备
                /// </summary>
                public const string RecruitTalentStateT = "20";
            }

            /// <summary>
            /// 过程类型
            /// </summary>
            public class ProcedureType
            {
                /// <summary>
                /// 推荐
                /// </summary>
                public const string ProcedureTypeA = "01";
                /// <summary>
                /// 筛选淘汰
                /// </summary>
                public const string ProcedureTypeB = "02";
                /// <summary>
                /// 筛选成功
                /// </summary>
                public const string ProcedureTypeC = "03";
                /// <summary>
                /// 安排面试
                /// </summary>
                public const string ProcedureTypeD = "04";
                /// <summary>
                /// 面试合格
                /// </summary>
                public const string ProcedureTypeE = "05";
                /// <summary>
                /// 面试淘汰
                /// </summary>
                public const string ProcedureTypeF = "06";
                /// <summary>
                /// 面试取消
                /// </summary>
                public const string ProcedureTypeG = "07";
                /// <summary>
                /// 面试结果审核淘汰
                /// </summary>
                public const string ProcedureTypeH = "08";
                /// <summary>
                /// 面试结果审核成功
                /// </summary>
                public const string ProcedureTypeI = "09";
                /// <summary>
                /// 发送Offer
                /// </summary>
                public const string ProcedureTypeJ = "10";
                /// <summary>
                /// 拒绝Offer
                /// </summary>
                public const string ProcedureTypeK = "11";
                /// <summary>
                /// 信息安全审核淘汰
                /// </summary>
                public const string ProcedureTypeL = "12";
                /// <summary>
                /// 背景调查审核淘汰
                /// </summary>
                public const string ProcedureTypeM = "13";
                /// <summary>
                /// 接受Offer
                /// </summary>
                public const string ProcedureTypeN = "14";
                /// <summary>
                /// 入职
                /// </summary>
                public const string ProcedureTypeO = "15";
                /// <summary>
                /// 取消Offer
                /// </summary>
                public const string ProcedureTypeP = "16";
                /// <summary>
                /// 放弃面试
                /// </summary>
                public const string ProcedureTypeQ = "17";
                /// <summary>
                /// Offer储备
                /// </summary>
                public const string ProcedureTypeR = "18";
            }

            /// <summary>
            /// 目的国 
            /// </summary>
            public class DestinationCode
            {
                /// <summary>
                /// 日本
                /// </summary>
                public const string DestinationCodeA = "01";
                /// <summary>
                /// 美国
                /// </summary>
                public const string DestinationCodeB = "02";
                /// <summary>
                /// 其他
                /// </summary>
                public const string DestinationCodeC = "03";
            }

            /// <summary>
            /// 出国人员角色 
            /// </summary>
            public class RoleCode
            {
                /// <summary>
                /// 现场责任者
                /// </summary>
                public const string RoleCodeA = "01";
                /// <summary>
                /// 出差担当
                /// </summary>
                public const string RoleCodeB = "02";
            }

            /// <summary>
            /// 邀请函发给方 
            /// </summary>
            public class InvitationLetterIssudeToParty
            {
                /// <summary>
                /// JHC
                /// </summary>
                public const string InvitationLetterIssudeToPartyA = "01";
                /// <summary>
                /// 客户
                /// </summary>
                public const string InvitationLetterIssudeToPartyB = "02";

            }

            /// <summary>
            /// 开发设备来源 
            /// </summary>
            public class EquipmentSources
            {
                /// <summary>
                /// 自带
                /// </summary>
                public const string EquipmentSourcesA = "01";
                /// <summary>
                /// 借用
                /// </summary>
                public const string EquipmentSourcesB = "02";
                /// <summary>
                /// 客户提供
                /// </summary>
                public const string EquipmentSourcesC = "03";
            }

            /// <summary>
            /// 出国理由 
            /// </summary>
            public class ToGoAbroadReason
            {
                /// <summary>
                /// 客户要求
                /// </summary>
                public const string ToGoAbroadReasonA = "01";
                /// <summary>
                /// 部门安排
                /// </summary>
                public const string ToGoAbroadReasonB = "02";
            }

            /// <summary>
            /// 出国费用负担者 
            /// </summary>
            public class CostBurden
            {
                /// <summary>
                /// 客户
                /// </summary>
                public const string CostBurdenA = "01";
                /// <summary>
                /// 部门
                /// </summary>
                public const string CostBurdenB = "02";
            }

            /// <summary>
            /// ID采集序列类型.
            /// </summary>
            /// <remarks></remarks>
            public class SequenceType
            {
                /// <summary>
                /// 职位
                /// </summary>
                public const string SequenceTypeSta = "Sta";
                /// <summary>
                /// 人员信息
                /// </summary>
                public const string SequenceTypePer = "Per";
                /// <summary>
                ///未纳入WEB-HR 系统自动编码公司的客户常驻人员
                /// </summary>
                public const string SequenceTypeUpm = "Upm";
                /// <summary>
                /// 成本中心
                /// </summary>
                public const string SequenceTypeCoc = "Coc";
                /// <summary>
                /// 大连华信教育软件服务有限公司全体人员
                /// </summary>
                public const string SequenceTypeDes = "Des";
                /// <summary>
                /// 华信永道(北京)科技有限公司全体人员
                /// </summary>
                public const string SequenceTypeHyd = "Hyd";
                /// <summary>
                /// 纳入WEB-HR系统的公司2013年1月1日以后新增人员
                /// </summary>
                public const string SequenceTypeCdn = "Cdn";
                /// <summary>
                /// 纳入WEB-HR系统自动编码的外协人员
                /// </summary>
                public const string SequenceTypeVen = "Ven";
                /// <summary>
                /// 未纳入WEB-HR系统自动编码公司的外协人员
                /// </summary>
                public const string SequenceTypeUve = "Uve";
                /// <summary>
                /// 华信计算机日本有限公司全体人员
                /// </summary>
                public const string SequenceTypeJhc = "Jhc";
                /// <summary>
                /// 中信网络科技股份有限公司全体人员
                /// </summary>
                public const string SequenceTypeHzx = "Hzx";
                /// <summary>
                /// 组织
                /// </summary>
                public const string SequenceTypeOrg = "Org";
                /// <summary>
                /// 沈阳华信教育科技有限公司,沈阳华信诺尔教育服务有限公司全体人员
                /// </summary>
                public const string SequenceTypeSes = "Sta";
                /// <summary>
                /// 纳入WEB-HR系统自动编码的客户常驻人员
                /// </summary>
                public const string SequenceTypePme = "Pme";
                /// <summary>
                /// 职务
                /// </summary>
                public const string SequenceTypePsi = "Psi";
                /// <summary>
                /// 特殊岗位
                /// </summary>
                public const string SequenceTypeEpi = "Epi";
                /// <summary>
                /// 证书种类
                /// </summary>
                public const string SequenceTypeCfs = "Cfs";
                /// <summary>
                /// 语言类证书
                /// </summary>
                public const string SequenceTypeLcf = "Lcf";
                /// <summary>
                /// IT认证类证书
                /// </summary>
                public const string SequenceTypeIcf = "Icf";
                /// <summary>
                /// 管理类证书
                /// </summary>
                public const string SequenceTypeMcf = "Mcf";
                /// <summary>
                /// 其它类证书
                /// </summary>
                public const string SequenceTypeOcf = "Ocf";
                /// <summary>
                /// 外协公司
                /// </summary>
                public const string SequenceTypeOrc = "Orc";
                /// <summary>
                /// 任职资格ID
                /// </summary>
                public const string SequenceTypeQUA = "QUA";
                /// <summary>
                /// 任职资料别名
                /// </summary>

                public const string SequenceTypeQaf = "Qaf";
                /// <summary>
                /// 项目评估报告别名
                /// </summary>
                public const string SequenceTypePaf = "Paf";

                /// <summary>
                /// 职位职务编号发番
                /// </summary>
                public const string SequenceTypeStationCode = "Sac";
                /// <summary>
                /// 外协公司编码
                /// </summary>
                public const string SequenceTypeVec = "Vec";
                /// <summary>
                /// MessageID编码
                /// </summary>
                public const string SequenceTypeMsg = "Msg";

            }

            /// <summary>
            /// 是否有效 
            /// </summary>
            public class IsValid
            {
                /// <summary>
                /// 有效
                /// </summary>
                public const string IsValidA = "01";
                /// <summary>
                /// 无效
                /// </summary>
                public const string IsValidB = "02";
            }

            /// <summary>
            /// 面试审核录用状态 
            /// </summary>
            public class AudEmployState
            {
                /// <summary>
                /// 未录用
                /// </summary>
                public const string AudEmployStateA = "01";
                /// <summary>
                /// 录用
                /// </summary>
                public const string AudEmployStateB = "02";
                /// <summary>
                /// 淘汰
                /// </summary>
                public const string AudEmployStateC = "03";
            }

            /// <summary>
            /// 公司内标志 
            /// </summary>
            public class IsInnerFlag
            {
                /// <summary>
                /// 公司内部
                /// </summary>
                public const string IsInnerFlagA = "01";
                /// <summary>
                /// 公司外部
                /// </summary>
                public const string IsInnerFlagB = "02";
            }

            /// <summary>
            /// 主职标志 
            /// </summary>
            public class MainFlag
            {
                /// <summary>
                /// 主职
                /// </summary>
                public const string MainFlagA = "01";
                /// <summary>
                /// 兼职
                /// </summary>
                public const string MainFlagB = "02";
            }

            /// <summary>
            /// 出国准备申请类型
            /// </summary>
            public class TGAReadyType
            {
                /// <summary>
                /// 基本类型
                /// </summary>
                public const string TGAReadyTypeA = "01";
                /// <summary>
                /// 事业部以上
                /// </summary>
                public const string TGAReadyTypeB = "02";
            }

            /// <summary>
            /// 邮箱标识 
            /// </summary>
            public class EmailFlg
            {
                /// <summary>
                /// 主邮箱
                /// </summary>
                public const string EmailFlgA = "01";
                /// <summary>
                /// 副邮箱
                /// </summary>
                public const string EmailFlgB = "02";
            }

            /// <summary>
            /// 简历更新时间 
            /// </summary>
            public class ResumeRenewalTime
            {
                /// <summary>
                /// 半月以下
                /// </summary>
                public const string ResumeRenewalTimeA = "01";
                /// <summary>
                /// 一月以下
                /// </summary>
                public const string ResumeRenewalTimeB = "02";
                /// <summary>
                /// 三月以下
                /// </summary>
                public const string ResumeRenewalTimeC = "03";
                /// <summary>
                /// 半年以下
                /// </summary>
                public const string ResumeRenewalTimeD = "04";
                /// <summary>
                /// 一年以下
                /// </summary>
                public const string ResumeRenewalTimeE = "05";
                /// <summary>
                /// 
                /// </summary>
                public const string ResumeRenewalTimeF = "06";
            }

            /// <summary>
            /// 处理状态 
            /// </summary>
            public class DisplayState
            {
                /// <summary>
                /// 待处理
                /// </summary>
                public const string DisplayStateA = "01";
                /// <summary>
                /// 处理中
                /// </summary>
                public const string DisplayStateB = "02";
                /// <summary>
                /// 已处理
                /// </summary>
                public const string DisplayStateC = "03";
            }

            /// <summary>
            /// 被推荐人才状态 
            /// </summary>
            public class RecStaffState
            {
                /// <summary>
                /// 未受理
                /// </summary>
                public const string RecStaffStateA = "01";
                /// <summary>
                /// 已受理
                /// </summary>
                public const string RecStaffStateB = "02";
                /// <summary>
                /// 驳回
                /// </summary>
                public const string RecStaffStateC = "03";

            }


            /// <summary>
            /// 招聘渠道.
            /// </summary>
            /// <remarks></remarks>
            public class RecruitChannel
            {
                /// <summary>
                /// 网站下载
                /// </summary>
                public const string RecruitChannelA = "01";
                /// <summary>
                /// 公司外网
                /// </summary>
                public const string RecruitChannelB = "02";
                /// <summary>
                /// 社会招聘会
                /// </summary>
                public const string RecruitChannelC = "03";
                /// <summary>
                /// 专场招聘会
                /// </summary>
                public const string RecruitChannelD = "04";
                /// <summary>
                /// 员工推荐
                /// </summary>
                public const string RecruitChannelE = "05";
                /// <summary>
                /// 猎头推荐
                /// </summary>
                public const string RecruitChannelF = "06";
                /// <summary>
                /// 员工返回
                /// </summary>
                public const string RecruitChannelG = "07";
                /// <summary>
                /// JHC返回
                /// </summary>
                public const string RecruitChannelH = "08";
                /// <summary>
                /// 单位外聘转
                /// </summary>
                public const string RecruitChannelI = "09";
                /// <summary>
                /// 校园招聘
                /// </summary>
                public const string RecruitChannelJ = "10";
                /// <summary>
                /// 报纸广告
                /// </summary>
                public const string RecruitChannelK = "11";
                /// <summary>
                /// 人脉
                /// </summary>
                public const string RecruitChannelL = "12";
                /// <summary>
                /// 其他
                /// </summary>
                public const string RecruitChannelM = "13";
                /// <summary>
                /// DHEE招聘
                /// </summary>
                public const string RecruitChannelN = "14";
                /// <summary>
                /// 外聘
                /// </summary>
                public const string RecruitChannelO = "15";
                /// <summary>
                /// 外协推荐
                /// </summary>
                public const string RecruitVendor = "16";
            }

            /// <summary>
            /// 评价状态 
            /// </summary>
            public class AppraiseState
            {
                /// <summary>
                /// 未评价
                /// </summary>
                public const string AppraiseStateA = "01";
                /// <summary>
                /// 已评价
                /// </summary>
                public const string AppraiseStateB = "02";
            }

            /// <summary>
            /// 是否退出项目 
            /// </summary>
            public class IsExitItem
            {
                /// <summary>
                /// 项目中
                /// </summary>
                public const string IsExitItemA = "01";
                /// <summary>
                /// 已退出项目
                /// </summary>
                public const string IsExitItemB = "02";
            }


            /// <summary>
            /// 审核状态 
            /// </summary>
            public class ApprovalStatus
            {
                /// <summary>
                /// 已审核
                /// </summary>
                public const string ApprovalStatusA = "01";
                /// <summary>
                /// 未审核
                /// </summary>
                public const string ApprovalStatusB = "02";
            }

            /// <summary>
            /// 日期类型.
            /// </summary>
            public class DateType
            {
                /// <summary>
                /// 工作日
                /// </summary>
                public const string WorkDay = "01";
                /// <summary>
                /// 休息日
                /// </summary>
                public const string RestDay = "02";
                /// <summary>
                /// 节假日
                /// </summary>
                public const string Holiday = "03";
            }

            /// <summary>
            /// 生效状态.
            /// </summary>
            public class EffectState
            {
                /// <summary>
                /// 未生效
                /// </summary>
                public const string EffectStateA = "01";
                /// <summary>
                /// 已生效
                /// </summary>
                public const string EffectStateB = "02";
                /// <summary>
                /// 取消生效
                /// </summary>
                public const string EffectStateC = "03";
            }

            /// <summary>
            /// 结束状态.
            /// </summary>
            public class EndFlag
            {
                /// <summary>
                /// 已结束
                /// </summary>
                public const string EndFlagA = "01";
                /// <summary>
                /// 未结束
                /// </summary>
                public const string EndFlagB = "02";
            }

            /// <summary>
            /// 合同类型.
            /// </summary>
            public class ContractType
            {
                /// <summary>
                /// 基本合同
                /// </summary>
                public const string ContractTypeA = "01";
                /// <summary>
                /// 个别合同
                /// </summary>
                public const string ContractTypeB = "02";
                /// <summary>
                /// 技术合同
                /// </summary>
                public const string ContractTypeC = "03";
            }

            /// <summary>
            /// 婚否.
            /// </summary>
            public class MarriageFlagCode
            {
                /// <summary>
                /// 未婚
                /// </summary>
                public const string MarriageFlagCodeA = "01";
                /// <summary>
                /// 已婚
                /// </summary>
                public const string MarriageFlagCodeB = "02";
            }

            /// <summary>
            /// 转正状态.
            /// </summary>
            public class PositiveState
            {
                /// <summary>
                /// 待转正
                /// </summary>
                public const string ToStayPositive = "01";
                /// <summary>
                /// 转正中
                /// </summary>
                public const string InThePositive = "02";
                /// <summary>
                /// 已转正
                /// </summary>
                public const string AlreadyPositive = "03";
            }


            /// <summary>
            /// 转正状态.
            /// </summary>
            public class WorkRoomState
            {
                /// <summary>
                /// 华信软件园内
                /// </summary>
                public const string WorkRoomState01 = "01";
                /// <summary>
                /// 华信软件园外
                /// </summary>
                public const string WorkRoomState02 = "02";
            }


            /// <summary>
            /// 调动类别.
            /// </summary>
            public class MobilizeCategory
            {
                /// <summary>
                /// 事业部内
                /// </summary>
                public const string MobilizeCategoryA = "01";
                /// <summary>
                /// 跨事业部
                /// </summary>
                public const string MobilizeCategoryB = "02";
                /// <summary>
                /// 跨公司
                /// </summary>
                public const string MobilizeCategoryC = "03";
            }

            /// <summary>
            /// 绩效考核结果.
            /// </summary>
            public class PEEvaluateResult
            {
                /// <summary>
                /// A
                /// </summary>
                public const string PEEvaluateResultA = "01";
                /// <summary>
                /// B
                /// </summary>
                public const string PEEvaluateResultB = "02";
                /// <summary>
                /// C
                /// </summary>
                public const string PEEvaluateResultC = "03";
                /// <summary>
                /// D
                /// </summary>
                public const string PEEvaluateResultD = "04";
                /// <summary>
                /// E
                /// </summary>
                public const string PEEvaluateResultE = "05";
            }

            /// <summary>
            /// 币种.
            /// </summary>
            public class ContractCurrency
            {
                /// <summary>
                /// 人民币
                /// </summary>
                public const string ChCurrency = "01";
                /// <summary>
                /// 万日元
                /// </summary>
                public const string JPCurrency = "02";
                /// <summary>
                /// 美元
                /// </summary>
                public const string USCurrency = "03";
                /// <summary>
                /// 其他
                /// </summary>
                public const string OTCurrency = "04";
            }

            /// <summary>
            /// Offer状态.
            /// </summary>
            public class OfferState
            {
                /// <summary>
                /// Offer未发送
                /// </summary>
                public const string OfferState01 = "01";
                /// <summary>
                /// Offer已发送
                /// </summary>
                public const string OfferState02 = "02";
                /// <summary>
                /// Offer拒绝
                /// </summary>
                public const string OfferState03 = "03";
                /// <summary>
                /// 待入职
                /// </summary>
                public const string OfferState04 = "04";
                /// <summary>
                /// 已入职
                /// </summary>
                public const string OfferState05 = "05";
                /// <summary>
                /// 取消Offer
                /// </summary>
                public const string OfferState06 = "06";
                /// <summary>
                /// Offer接受
                /// </summary>
                public const string OfferState07 = "07";
                /// <summary>
                /// 待考虑
                /// </summary>
                public const string OfferState08 = "08";
                /// <summary>
                /// 其他
                /// </summary>
                public const string OfferState09 = "09";
            }

            /// <summary>
            /// 登陆角色.
            /// </summary>
            public class LoginRole
            {
                /// <summary>
                /// 高管
                /// </summary>
                public const string HigherManager = "01";
                /// <summary>
                /// 部门负责人
                /// </summary>
                public const string DeptManager = "02";
                /// <summary>
                /// 普通员工
                /// </summary>
                public const string Staff = "03";
            }

            /// <summary>
            /// 出国目的.
            /// </summary>
            public class PurposeCode
            {
                /// <summary>
                /// 研修
                /// </summary>
                public const string PurposeCode06 = "06";
            }
            /// <summary>
            /// 是否与部门签订了《DHC转籍JHC协议》.
            /// </summary>
            public class JHCSiteStatus
            {
                /// <summary>
                /// 已签订
                /// </summary>
                public const string JHCSiteStatus01 = "01";
                /// <summary>
                /// 未签订
                /// </summary>
                public const string JHCSiteStatus02 = "02";
            }

            /// <summary>
            /// 工作地点
            /// </summary>
            public class WorkPlace
            {
                /// <summary>
                /// 已签订
                /// </summary>
                public const string Dalian = "01";
            }


            /// <summary>
            /// 评价需求.
            /// </summary>
            public class NeedEvaluate
            {
                /// <summary>
                /// 需要评价
                /// </summary>
                public const string YES = "01";
                /// <summary>
                /// 无需评价
                /// </summary>
                public const string NO = "02";
            }

            /// <summary>
            /// 评价需求状态.
            /// </summary>
            public class EvaluateAttribute
            {
                /// <summary>
                /// 评价未提交
                /// </summary>
                public const string AllNoSubmit = "01";
                /// <summary>
                /// 项目未评价
                /// </summary>
                public const string ProjectNoSubmit = "02";
                /// <summary>
                /// 信息安全未评价
                /// </summary>
                public const string SafetyNoSubmit = "03";
                /// <summary>
                /// 评价完毕
                /// </summary>
                public const string AllSubmit = "04";
            }

            /// <summary>
            /// 评价需求状态(名称).
            /// </summary>
            public class EvaluateAttributeName
            {
                /// <summary>
                /// 评价未提交
                /// </summary>
                public const string AllNoSubmit = "评价未提交";
                /// <summary>
                /// 项目未评价
                /// </summary>
                public const string ProjectNoSubmit = "项目未评价";
                /// <summary>
                /// 信息安全未评价
                /// </summary>
                public const string SafetyNoSubmit = "信息安全未评价";
                /// <summary>
                /// 评价完毕
                /// </summary>
                public const string AllSubmit = "评价完毕";
            }

            /// <summary>
            /// 在职状态(名称).
            /// </summary>
            /// <remarks></remarks>
            public class OfficeStateName
            {
                /// <summary>
                /// 在职
                /// </summary>
                public const string OfficeState01 = "在职";
                /// <summary>
                /// 离职
                /// </summary>
                public const string OfficeState02 = "离职";
            }

            /// <summary>
            /// 项目角色名称.
            /// </summary>
            /// <remarks></remarks>
            public class RoleInProject
            {
                /// <summary>
                /// 项目责任人
                /// </summary>
                public const string ProjectOwner = "01";
                /// <summary>
                /// 项目经理PM
                /// </summary>
                public const string ProjectManager = "02";
                /// <summary>
                /// 项目组长PSL
                /// </summary>
                public const string ProjectSubLeader = "03";
                /// <summary>
                /// 进步管理员
                /// </summary>
                public const string ProgressManager = "04";
                /// <summary>
                /// 质量管理员
                /// </summary>
                public const string QualityManager = "05";
                /// <summary>
                /// 项目窗口
                /// </summary>
                public const string ProjectWindow = "06";
                /// <summary>
                /// 需求调研员
                /// </summary>
                public const string RequirementInquiry = "11";
                /// <summary>
                /// 需求分析员
                /// </summary>
                public const string RequirementAnalyst = "12";
                /// <summary>
                /// 系统分析员
                /// </summary>
                public const string SystemAnalyst = "13";
                /// <summary>
                /// 系统架构师
                /// </summary>
                public const string SystemArchitect = "14";
                /// <summary>
                /// 软件架构师
                /// </summary>
                public const string SoftwareArchitect = "15";
                /// <summary>
                /// 业务设计员
                /// </summary>
                public const string BusinessDesigner = "16";
                /// <summary>
                /// 系统设计员
                /// </summary>
                public const string SystemDesigner = "17";
                /// <summary>
                /// 数据库设计员
                /// </summary>
                public const string DBDesigner = "18";
                /// <summary>
                /// 设计员
                /// </summary>
                public const string Designer = "19";
                /// <summary>
                /// 程序员
                /// </summary>
                public const string Programmer = "20";
                /// <summary>
                /// 测试设计员
                /// </summary>
                public const string TestDesigner = "21";
                /// <summary>
                /// 测试员
                /// </summary>
                public const string Tester = "22";
                /// <summary>
                /// 项目实施人员
                /// </summary>
                public const string Actualizer = "23";
            }

            /// <summary>
            /// 月份.
            /// </summary>
            /// <remarks></remarks>
            public class ExMonth
            {

                public const string Jan = "01";

                public const string Feb = "02";

                public const string Mar = "03";

                public const string Apr = "04";

                public const string May = "05";

                public const string Jun = "06";

                public const string Jul = "07";

                public const string Aug = "08";

                public const string Sep = "09";

                public const string Oct = "10";

                public const string Nov = "11";

                public const string Dec = "12";
            }

            /// <summary>
            /// 下载内容.
            /// </summary>
            /// <remarks></remarks>
            public class DownLoadFile
            {
                /// <summary>
                /// 项目论文
                /// </summary>
                public const string Down01 = "01";
                /// <summary>
                /// 技术方案
                /// </summary>
                public const string Down02 = "02";
                /// <summary>
                /// 个人信息表
                /// </summary>
                public const string Down03 = "03";
                /// <summary>
                /// 项目评估报告
                /// </summary>
                public const string Down04 = "04";
            }

            /// <summary>
            /// 发布状态.
            /// </summary>
            /// <remarks></remarks>
            public class OpeState
            {
                /// <summary>
                /// 已发布
                /// </summary>
                public const string OpeState01 = "01";
                /// <summary>
                /// 未发布
                /// </summary>
                public const string OpeState02 = "02";
            }

            /// <summary>
            /// 发布状态(名称).
            /// </summary>
            /// <remarks></remarks>
            public class OpeStateName
            {
                /// <summary>
                /// 已发布
                /// </summary>
                public const string OpeState01 = "已发布";
                /// <summary>
                /// 未发布
                /// </summary>
                public const string OpeState02 = "未发布";
            }

            /// <summary>
            /// 审批状态.
            /// </summary>
            public class ApplyStateName
            {
                /// <summary>
                /// 启动申请
                /// </summary>
                public const string ApplyStart = "启动申请";
                /// <summary>
                /// 撤销申请
                /// </summary>
                public const string ApplyBack = "撤销申请";
                /// <summary>
                /// 审批中
                /// </summary>
                public const string Applying = "审批中";
                /// <summary>
                /// 审批驳回
                /// </summary>
                public const string ApplyNG = "审批驳回";
                /// <summary>
                /// 审批通过
                /// </summary>
                public const string ApplyOK = "审批通过";
                /// <summary>
                /// 填报中
                /// </summary>
                public const string ApplyNoStart = "填报中";
                /// <summary>
                /// 重新填报中
                /// </summary>
                public const string ApplyReplay = "重新填报中";
            }

            /// <summary>
            /// 任职资格需求资料类型.
            /// </summary>
            public class QualicFileState
            {
                /// <summary>
                /// 培训课件
                /// </summary>
                public const string QualicFileState01 = "01";
                /// <summary>
                /// 项目论文
                /// </summary>
                public const string QualicFileState02 = "02";
                /// <summary>
                /// 技术方案
                /// </summary>
                public const string QualicFileState03 = "03";
                /// <summary>
                /// 个人信息表
                /// </summary>
                public const string QualicFileState04 = "04";
                /// <summary>
                /// 项目评估报告
                /// </summary>
                public const string QualicFileState05 = "05";
            }

            /// <summary>
            /// 任职资格需求资料类型(名称).
            /// </summary>
            public class QualicFileStateName
            {
                /// <summary>
                /// 培训课件
                /// </summary>
                public const string QualicFileState01 = "培训课件";
                /// <summary>
                /// 项目论文
                /// </summary>
                public const string QualicFileState02 = "项目论文";
                /// <summary>
                /// 技术方案
                /// </summary>
                public const string QualicFileState03 = "技术方案";
                /// <summary>
                /// 个人信息表
                /// </summary>
                public const string QualicFileState04 = "个人信息表";
                /// <summary>
                /// 项目评估报告
                /// </summary>
                public const string QualicFileState05 = "项目评估报告";
            }

            /// <summary>
            /// 考核评级(名称).
            /// </summary>
            public class PEGradeName
            {
                /// <summary>
                /// 卓越
                /// </summary>
                public const string PEGradeA = "卓越";
                /// <summary>
                /// 优秀
                /// </summary>
                public const string PEGradeB = "优秀";
                /// <summary>
                /// 胜任
                /// </summary>
                public const string PEGradeC = "胜任";
                /// <summary>
                /// 需改进
                /// </summary>
                public const string PEGradeD = "需改进";
                /// <summary>
                /// 差
                /// </summary>
                public const string PEGradeE = "差";
            }

            /// <summary>
            /// 任职资格状态.
            /// </summary>
            public class QualificationState
            {
                /// <summary>
                /// 新增
                /// </summary>
                public const string QualificationState01 = "01";
                /// <summary>
                /// 晋升
                /// </summary>
                public const string QualificationState02 = "02";
                /// <summary>
                /// 取消
                /// </summary>
                public const string QualificationState03 = "03";
                /// <summary>
                /// 延期
                /// </summary>
                public const string QualificationState04 = "04";
                /// <summary>
                /// 失败
                /// </summary>
                public const string QualificationState05 = "05";
                /// <summary>
                /// 降级
                /// </summary>
                public const string QualificationState06 = "06";
            }

            /// <summary>
            /// 同步分类.
            /// </summary>
            public class UpdateFlg
            {
                /// <summary>
                /// 同步(4级以下)
                /// </summary>
                public const string UpdateFlg01 = "01";
                /// <summary>
                /// 同步(4级以上)
                /// </summary>
                public const string UpdateFlg02 = "02";
            }

            /// <summary>
            /// 填表要求.
            /// </summary>
            public class NeedForm
            {
                /// <summary>
                /// 不需要
                /// </summary>
                public const string NeedForm01 = "01";
                /// <summary>
                /// 需要
                /// </summary>
                public const string NeedForm02 = "02";
            }

            /// <summary>
            /// 任命类型.
            /// </summary>
            public class InstateType
            {
                /// <summary>
                /// 公司任命
                /// </summary>
                public const string InstateType01 = "01";
                /// <summary>
                /// 部门任命
                /// </summary>
                public const string InstateType02 = "02";
            }

            /// <summary>
            /// 简历公开程度.
            /// </summary>
            public class InstrumentPanelAuthority
            {
                /// <summary>
                /// 公开
                /// </summary>
                public const string InstrumentPanelAuthorityA = "01";
                /// <summary>
                /// 保密
                /// </summary>
                public const string InstrumentPanelAuthorityB = "02";
            }

            /// <summary>
            /// 任职资格简称.
            /// </summary>
            public class QualificationAbbreviation
            {
                /// <summary>
                /// 高级软件工程师
                /// </summary>
                public const string QAbbreviation01 = "SSE";
                /// <summary>
                /// 软件工程师
                /// </summary>
                public const string QAbbreviation02 = "SE";
                /// <summary>
                /// 高级软件测试工程师
                /// </summary>
                public const string QAbbreviation03 = "SSTE";
                /// <summary>
                /// 软件工程师（测试）
                /// </summary>
                public const string QAbbreviation04 = "STE";
                /// <summary>
                /// 初级软件工程师
                /// </summary>
                public const string QAbbreviation05 = "JSE";
                /// <summary>
                /// 初级软件工程师（测试）
                /// </summary>
                public const string QAbbreviation06 = "JSTE";
                /// <summary>
                /// 助理软件工程师
                /// </summary>
                public const string QAbbreviation07 = "ASE";
                /// <summary>
                /// 助理软件工程师（测试）
                /// </summary>
                public const string QAbbreviation08 = "ASTE";
            }

            /// <summary>
            /// 评审安排状态.
            /// </summary>
            public class AppraisalSchedule
            {
                /// <summary>
                /// 未安排
                /// </summary>
                public const string AppraisalScheduleA = "01";
                /// <summary>
                /// 已安排
                /// </summary>
                public const string AppraisalScheduleB = "02";
            }

            /// <summary>
            /// 证书确认.
            /// </summary>
            public class CertificateConfirm
            {
                /// <summary>
                /// 证书原件
                /// </summary>
                public const string CertificateConfirmOriginal = "01";
                /// <summary>
                /// 证书副本
                /// </summary>
                public const string CertificateConfirmCopy = "02";
            }

            /// <summary>
            /// 调出调入本部门类别.
            /// </summary>
            public class InOrOurOrgType
            {
                /// <summary>
                /// 调出本部门
                /// </summary>
                public const string InOrOurOrgTypeOut = "01";
                /// <summary>
                /// 调入本部门
                /// </summary>
                public const string InOrOurOrgTypeIn = "02";
            }

            /// <summary>
            /// 业务类型.
            /// </summary>
            public class BusinessCategory
            {
                /// <summary>
                /// 对日业务
                /// </summary>
                public const string BusinessCategory01 = "01";
                /// <summary>
                /// 欧美业务
                /// </summary>
                public const string BusinessCategory02 = "02";
                /// <summary>
                /// 国内业务
                /// </summary>
                public const string BusinessCategory03 = "03";
                /// <summary>
                /// 通用业务
                /// </summary>
                public const string BusinessCategory04 = "04";
            }
            /// <summary>
            /// 指标项.
            /// </summary>
            public class IndicatorTerms
            {
                /// <summary>
                /// 外语能力
                /// </summary>
                public const string IndicatorTerms01 = "01";
                /// <summary>
                /// 持有业务证书
                /// </summary>
                public const string IndicatorTerms02 = "02";
                /// <summary>
                /// 培训时间
                /// </summary>
                public const string IndicatorTerms03 = "03";
                /// <summary>
                /// 工作年限
                /// </summary>
                public const string IndicatorTerms04 = "04";
                /// <summary>
                /// 项目管理年限
                /// </summary>
                public const string IndicatorTerms05 = "05";
                /// <summary>
                /// 客户现场工作时间
                /// </summary>
                public const string IndicatorTerms06 = "06";
            }
            /// <summary>
            /// 适用阶段.
            /// </summary>
            public class Stage
            {
                /// <summary>
                /// 初次申请
                /// </summary>
                public const string Stage01 = "01";
                /// <summary>
                /// 延时申请
                /// </summary>
                public const string Stage02 = "02";
            }
            /// <summary>
            /// 是否硬指标.
            /// </summary>
            public class IndicatorMust
            {
                /// <summary>
                /// 是
                /// </summary>
                public const string IndicatorMust01 = "01";
                /// <summary>
                /// 否
                /// </summary>
                public const string IndicatorMust02 = "02";
            }

        }
        #endregion

        #region 其它定数.
        /// <summary>
        /// 其它定数.
        /// </summary>
        public class ExOther
        {
            /// <summary>
            /// 描述 - 公司成立年份
            /// </summary>
            public const string CFristYear = "1996";
            /// <summary>
            /// 描述 - 开始日期
            /// </summary>
            public const string CStartDate = "开始日期";
            /// <summary>
            ///  描述 - 结束日期
            /// </summary>
            public const string CEndDate = "结束日期";
            /// <summary>
            /// 描述 - 当前日期
            /// </summary>
            public const string CNowDate = "当前日期";
            /// <summary>
            /// 描述 - 失效日期
            /// </summary>
            public const string CExpirationDate = "失效日期";
            /// <summary>
            /// 描述 - 日期 - 最大日期
            /// </summary>
            public const string CMinDate = "19000101";
            /// <summary>
            /// 描述 - 日期 - 最小日期
            /// </summary>
            public const string CMaxDate = "20991231";
            /// <summary>
            /// 描述 - 受理状态 - 已受理
            /// </summary>
            public const string COffAccept = "已受理";
            /// <summary>
            /// 描述 - 受理状态 - 未受理
            /// </summary>
            public const string CUnAccept = "未受理";
            /// <summary>
            /// 描述 - 申请 - 默认申请开始日
            /// </summary>
            public const string CDefaultApplyStartDate = "0101";
            /// <summary>
            /// 描述 - 申请 - 默认申请结束日
            /// </summary>
            public const string CDefaultApplyEndDate = "1231";
            /// <summary>
            /// 描述 - 码表 - 码表键
            /// </summary>
            public const string CCodeName = "CodeName";
            /// <summary>
            /// 描述 - 码表 - 码表值
            /// </summary>
            public const string CCodeMasterCode = "CodeMasterCode";
            /// <summary>
            /// 描述 - 年数 - 表示最大的历史年数
            /// </summary>
            public const string CHistoryMaxYearCount = "HistoryMaxYearCount";
            /// <summary>
            /// 描述 - 天数 - 表示最大的可预订的天数
            /// </summary>
            public const string CConferenceReserveMaxDays = "ConferenceReserveMaxDays";
            /// <summary>
            /// 描述 - 小时数 - 表示最大的可预订的小时数
            /// </summary>
            public const string CConferenceReserveMaxHours = "ConferenceReserveMaxHours";
            /// <summary>
            /// 描述 - 月份 - 开始月
            /// </summary>
            public const int CFirstMonth = 1;
            /// <summary>
            /// 描述 - 月份 - 终了月
            /// </summary>
            public const int CLastMonth = 12;
            /// <summary>
            /// 描述 - 全部的值
            /// </summary>
            public const string CAllDataCode = "99";
            /// <summary>
            /// 描述 - 全部的名称
            /// </summary>
            public const string CAllDataName = "全部";
            /// <summary>
            /// 描述 - ESB数据同步用，数据状态
            /// </summary>
            public const string CRowStateAdd = "Add";
            /// <summary>
            /// 描述 - ESB数据同步用，数据状态
            /// </summary>
            public const string CRowStateAddName = "新规";
            /// <summary>
            /// 描述 - ESB数据同步用，数据状态
            /// </summary>
            public const string CRowStateUpdate = "Edit";
            /// <summary>
            /// 描述 - ESB数据同步用，数据状态
            /// </summary>
            public const string CRowStateUpdateName = "更新";
            /// <summary>
            /// 描述 - ESB数据同步用，数据状态
            /// </summary>
            public const string CRowStateDel = "Delete";
            /// <summary>
            /// 描述 - ESB数据同步用，数据状态
            /// </summary>
            public const string CRowStateDelName = "删除";
            /// <summary>
            /// 描述 - PMS专用：各系统自行定义
            /// </summary>
            public const string ErrMailTitle = "ESB调用EHR接口异常（正式环境）";
            /// <summary>
            /// 2016/07/05 对应工单:00009180-20160629-765 By FCP 离职和预计离职人员信息共享 Start 
            /// </summary>
            public const string LeaveEnjoyMailTitle = "总部离职倾向人员信息推送";
            /// <summary>
            ///  2016/07/05 对应工单:00009180-20160629-765 By FCP 离职和预计离职人员信息共享 End 
            /// </summary>
            public const string strLogContent01 = "ESB申请对";

            public const string strLogContent02 = "进行";

            public const string strLogContent03 = "操作。";

            public const string strMailContentEnd = "<p>&nbsp;</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;大连华信人力资源管理系统（EHR）</p>" +
                                                       "<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{0}</p>";
            /// <summary>
            ///描述 - 年
            /// </summary>
            public const string CYear = "年";
            /// <summary>
            /// 描述 -月
            /// </summary>
            public const string CMonth = "月";
            /// <summary>
            /// 描述 -日
            /// </summary>
            public const string CDay = "日";
            /// <summary>
            /// 描述 -所属组织
            /// </summary>
            public const string OrgStatus = "01";
            /// <summary>
            /// 描述 -其他组织
            /// </summary>
            public const string OrgStatusOther = "02";
            /// <summary>
            /// 描述 -目标活动
            /// </summary>
            public const string GoalSubject = "目标活动";
            /// <summary>
            /// 描述 -考核活动
            /// </summary>
            public const string Subject = "考核活动";
            /// <summary>
            /// 描述 -权限类型编号
            /// </summary>
            public const string AuthorTypeNumber = "100000";
            /// <summary>
            /// 描述 - 分隔符
            /// </summary>
            public const string CSlash = @"\";
            /// <summary>
            /// 描述 - 分隔符
            /// </summary>
            public const string CSlashR = "/";
            /// <summary>
            /// 描述 - 分隔符
            /// </summary>
            public const string CColon = ":";
            /// <summary>
            /// 描述 - 参加考核
            /// </summary>
            public const string CAttendPE = "0";
            /// <summary>
            /// 描述 - 不参加考核
            /// </summary>
            public const string CNotAtttendPE = "1";
            /// <summary>
            /// 描述 - 导入模板列数
            /// </summary>
            public const int CImportColumn = 8;
            /// <summary>
            /// 描述 - 考核表查看
            /// </summary>
            public const string CViewEvaluateTable = "考核表查看";
            /// <summary>
            /// 描述 - 考核表编辑
            /// </summary>
            public const string CEditEvaluateTable = "考核表编辑";
            /// <summary>
            /// 描述 - 查看
            /// </summary>
            public const string CView = "查看";
            /// <summary>
            /// 描述 - 逗号
            /// </summary>
            public const string CComma = "','";
            /// <summary>
            /// 描述 - 考核框架UID
            /// </summary>
            public const string CPEFrameInfoUID = "PEFrameInfoUID";
            /// <summary>
            /// 描述 - 无权限
            /// </summary>
            public const string CNoAuthor = "01";
            /// <summary>
            /// 描述 - 有权限
            /// </summary>
            public const string CHasAuthor = "02";
            /// <summary>
            /// 描述 - 目标设定确认Flag
            /// </summary>
            public const string CPEGoalStateFlag = "00";
            /// <summary>
            /// 描述 - 数据名称
            /// </summary>
            public const string CDataName = "无";
            /// <summary>
            /// 描述 - 写
            /// </summary>
            public const string CWrite = "01";
            /// <summary>
            /// 描述 - 读
            /// </summary>
            public const string CRead = "02";
            /// <summary>
            /// 描述 - 非虚拟组织
            /// </summary>
            public const string CInventOrg = "1";
            /// <summary>
            /// 描述 - 是虚拟组织
            /// </summary>
            public const string CInventOrgYes = "0";
            /// <summary>
            /// 描述 - 被淘汰者
            /// </summary>
            public const string CWashOutFlag = "1";
            /// <summary>
            /// 描述 - 导出方式：根据人员导出
            /// </summary>
            public const string ExportTypeByPerson = "0";
            /// <summary>
            /// 描述 - 导出方式：根据模板导出
            /// </summary>
            public const string ExportTypeByTable = "1";
            /// <summary>
            /// 描述 - 不符合
            /// </summary>
            public const string UnAccord = "0";
            /// <summary>
            /// 描述 - 符合
            /// </summary>
            public const string Accord = "1";
            /// <summary>
            /// 描述 - 指标类别
            /// </summary>
            public const string CExcelIndicatorType = "指标类别";
            /// <summary>
            /// 描述 - 指标类别权重
            /// </summary>
            public const string CExcelIndicatorTypePercent = "指标类别权重";
            /// <summary>
            /// 描述 - 指标名
            /// </summary>
            public const string CExcelIndicatorName = "指标名";
            /// <summary>
            /// 描述 - 指标权重
            /// </summary>
            public const string CExcelIndicatorPercent = "指标权重";
            /// <summary>
            /// 描述 - 区分
            /// </summary>
            public const string CExcelDifferentiate = "区分";
            /// <summary>
            /// 描述 - 目标
            /// </summary>
            public const string CExcelGoal = "目标";
            /// <summary>
            /// 描述 - 参照目标
            /// </summary>
            public const string CExcelConsultGoal = "参照目标";
            /// <summary>
            /// 描述 - -
            /// </summary>
            public const string CExcelMinline = "-";
            /// <summary>
            /// 描述 - _
            /// </summary>
            public const string CExcelUnderline = "_";
            /// <summary>
            /// 描述 -，
            /// </summary>
            public const string CExcelComma = ",";
            /// <summary>
            /// 描述 -'
            /// </summary>
            public const string CSingleQuotes = "'";
            /// <summary>
            /// 描述 -分隔符
            /// </summary>
            public const string CFlag = "|";
            /// <summary>
            /// 描述 -分隔符
            /// </summary>
            public const string CFaaaa = "～";
            /// <summary>
            /// 描述 -@
            /// </summary>
            public const string CAt = "@";
            /// <summary>
            /// 描述 -男
            /// </summary>
            public const string Man = "男";
            /// <summary>
            /// 描述 -女
            /// </summary>
            public const string Woman = "女";
            /// <summary>
            /// 描述 -在职
            /// </summary>
            public const string Incumbency = "在职";
            /// <summary>
            /// 描述 -离职
            /// </summary>
            public const string Dimission = "离职";
            /// <summary>
            /// 描述 -英语
            /// </summary>
            public const string CEnglish = "英语";
            /// <summary>
            /// 描述 -日语
            /// </summary>
            public const string CJapanese = "日语";
            /// <summary>
            /// 描述 -朝鲜语
            /// </summary>
            public const string CKorea = "朝鲜语";
            /// <summary>
            /// 描述 -其他
            /// </summary>
            public const string COtherLanguage = "其他";
            /// <summary>
            /// 描述 -最小年度
            /// </summary>
            public const string CMinYear = "1996";
            /// <summary>
            /// 描述 -用户权限添加用Flag
            /// </summary>
            public const string CAuthorityDeptFlag = "01";
            /// <summary>
            /// 描述 -设置标识
            /// </summary>
            public const string CSetFlag = "01";
            /// <summary>
            /// 描述 -目标设定Flag
            /// </summary>
            public const string CGoalFlag = "01";
            /// <summary>
            /// 描述 -添加标识
            /// </summary>
            public const string CEditFlg = "0";
            /// <summary>
            /// 描述 -考核设定Flag
            /// </summary>
            public const string CAppraiseFlag = "02";
            /// <summary>
            /// 描述 -自评
            /// </summary>
            public const string CSelfScore = "自我评价";
            /// <summary>
            /// 描述 -上级评价
            /// </summary>
            public const string CEvaluateScore = "上级评价";
            /// <summary>
            /// 描述 -增减项
            /// </summary>
            public const string CSelfChange = "自评增减项";
            /// <summary>
            /// 描述 -增减项
            /// </summary>
            public const string CScoreChange = "上级增减项";
            /// <summary>
            /// 描述 -考核等级
            /// </summary>
            public const string CGrade = "考核等级";
            /// <summary>
            /// 描述 -考核状态Check
            /// </summary>
            public const string CAppraiseStatusMsg = "导入失败！考核状态非【自评中】【考核中】【审核驳回】！";
            /// <summary>
            /// 描述 -增减分格式Check
            /// </summary>
            public const string CChangeScoreMsg = "导入失败！增减分格式不正确！";
            /// <summary>
            ///描述 - 等级空Check
            /// </summary>
            public const string CGardNullMsg = "导入失败！考核等级不能为空！";
            /// <summary>
            /// 描述 -等级格式Check
            /// </summary>
            public const string CGardTypeMsg = "导入失败！考核等级格式不正确！";
            /// <summary>
            /// 描述 -评价空Check
            /// </summary>
            public const string CSelfNullMsg = "导入失败！自评分数不能为空！";
            /// <summary>
            /// 描述 -评价空Check
            /// </summary>
            public const string CAppraiseNullMsg = "导入失败！上级评价分数不能为空！";
            /// <summary>
            /// 描述 -评价类型Check
            /// </summary>
            public const string CSelfTypeMsg = "导入失败！自评分数应为数值型！";
            /// <summary>
            /// 描述 -评价类型Check
            /// </summary>
            public const string CAppraiseTypeMsg = "导入失败！上级评价分数应为数值型！";
            /// <summary>
            /// 描述 -评价区间Check
            /// </summary>
            public const string CAppraiseBetweenMsg = "导入失败！上级评价分数应在0-5之间！";
            /// <summary>
            /// 描述 -评价区间Check
            /// </summary>
            public const string CChangeBetweenMsg = "导入失败！增减分数应在0-5之间！";
            /// <summary>
            /// 描述 -评价区间Check
            /// </summary>
            public const string COselfBetweenMsg = "导入失败！自评分数应在0-5之间！";
            /// <summary>
            /// 描述 -评价区间Check
            /// </summary>
            public const string COselfSumBetweenMsg = "导入失败！自评总分应在0-5之间！";
            /// <summary>
            /// 描述 -评价区间Check
            /// </summary>
            public const string CAppraiseSumBetweenMsg = "导入失败！考核总分数应在0-5之间！";
            /// <summary>
            /// 描述 -目标状态Check
            /// </summary>
            public const string CGoalStatusMsg = "导入失败！目标状态非【未设定】【设定中】【审核驳回】！";
            /// <summary>
            /// 描述 -导入数据空Check
            /// </summary>
            public const string CEnterNotNull = "不能为空...";
            /// <summary>
            /// 描述 -导入数据数字Chec
            /// </summary>
            public const string CEnterNotNumber = "不是数字...";
            /// <summary>
            /// 描述 -导入数据数字不能小于0
            /// </summary>
            public const string CEnterNotLessThanZero = "不能小于0...";
            /// <summary>
            /// 描述 - 导入数据重复Check
            /// </summary>
            public const string CEnterIterance = "数据已存在，不能重复导入！";
            /// <summary>
            /// 描述 - 导入数据有效期间Check
            /// </summary>
            public const string CInstateSessionClash = "员工任职有效期间与前一任职有效期间冲突，请确认.";
            /// <summary>
            /// 描述 - 导入数据有效期间Check
            /// </summary>
            public const string CPositionSessionClash = "员工任命有效期间与前一任命有效期间冲突，请确认.";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string StaffPStationManageOut = "组织编号、特殊岗位编号、员工编号、员工姓名录入不正确..";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string StaffPStationManageTime = "开始日期和结束日期不合逻辑...";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string StaffPositionManageDate = "数据不正确...";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CErrMsg = "没有设定目标关系，无法导入考核关系！";
            /// <summary>
            /// 描述 - 正确Msg
            /// </summary>
            public const string COKMsg = "导入成功！";
            /// <summary>
            /// 描述 - 数据不存在
            /// </summary>
            public const string CDataNullMsg = "数据不存在！";
            /// <summary>
            /// 描述 - 导入时的员工不存在
            /// </summary>
            public const string CStaffNotExistMsg = "的员工不存在！";
            /// <summary>
            /// 2016/10/21 对应工单：00009180-20161021-979 By FCP 新员工转正申请相关变更 Start
            /// </summary>
            public const string CProbationApplyMsg = "该员工未完成新员工入职培训，如发起转正将进入特殊审批流程!";
            /// <summary>
            /// 校园招聘年度取值分界线，4月1日前为今年，4月1日后为下一年
            /// </summary>
            public const string CSchoolRecruitmentPlanYear = "0401";
            /// <summary>
            /// 描述 - 录入的卡号对应的姓名和录入的姓名不一致
            /// </summary>
            public const string CCheckStaffCodeAndName = "录入的卡号对应的姓名和录入的姓名不一致";
            /// <summary>
            /// 描述 - 录入格式不正确
            /// </summary>
            public const string CCheckEnterFormat = "录入格式不正确";
            /// <summary>
            /// 描述 - 被考核人员角色
            /// </summary>
            public const string CPEStaffUID = "PEStaffUID";
            /// <summary>
            /// 描述 - 考核人员角色
            /// </summary>
            public const string CPETargetStaffUID = "PETargetStaffUID";
            /// <summary>
            /// 描述 - 审核人员角色
            /// </summary>
            public const string CPECheckStaffUID = "PECheckStaffUID";
            /// <summary>
            /// 描述 - 文件上传时指定文件夹的UID
            /// </summary>
            public const string CFileManageUID = "e16dea9c-404e-466e-811c-9cd99dfa9bb9";
            /// <summary>
            /// 描述 - 合同模板UID
            /// </summary>
            public const string CContractInfoFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8590E";
            /// <summary>
            /// 描述 - 档案模板UID
            /// </summary>
            public const string CArchivesInfoFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8591E";
            /// <summary>
            /// 描述 - 户籍导出模板UID
            /// </summary>
            public const string CCensusInfoFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8592E";
            /// <summary>
            /// 描述 - 目标关系模板文件UID
            /// </summary>
            public const string CGoalRelationFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8593E";
            /// <summary>
            /// 描述 - 考核关系模板文件UID
            /// </summary>
            public const string CSubjectRelationFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8594E";
            /// <summary>
            /// 描述 - 绩效目标设定UID
            /// </summary>
            public const string CSettingGoalFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8596E";
            /// <summary>
            /// 描述 - 人员组织关系模板文件UID
            /// </summary>
            public const string CStaffOrganizationFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8595E";
            /// <summary>
            /// 描述 - 大连华信计算机技术股份有限公司
            /// </summary>
            public const string OrganizationDHC = "00000000-0000-0000-0000-000000000001";
            /// <summary>
            /// 描述 -员工特殊岗位模板文件UID
            /// </summary>
            public const string CStaffStationFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8597E";
            /// <summary>
            /// 描述 -目标导出：根据模板导出UID
            /// </summary>
            public const string CSettingGoalListFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8600E";
            /// <summary>
            /// 描述 -员工出国申请信息导出模板UID
            /// </summary>
            public const string CToGoAbroadReserveFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8599E";
            /// <summary>
            /// 描述 -组织信息导入模板UID
            /// </summary>
            public const string COrgInfoUID = "04AA669F-4385-42ED-A7A1-15FCAFA8601E";
            /// <summary>
            /// 描述 -签证模板UID
            /// </summary>
            public const string CStaffVisaUID = "04AA669F-4385-42ED-A7A1-15FCAFA8598E";
            /// <summary>
            /// 描述 -成本中心信息模板
            /// </summary>
            public const string CCostCenterInfoUID = "04AA669F-4385-42ED-A7A1-15FCAFA8604E";
            /// <summary>
            /// 描述 -校园人才模板文件UID
            /// </summary>
            public const string CSchoolTalentFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8697E";
            /// <summary>
            /// 描述 -导出方式：根据人员导出.(考核导出)
            /// </summary>
            public const string CSettingAppraiseUID = "04AA669F-4385-42ED-A7A1-15FCAFA8605E";
            /// <summary>
            /// 描述 -导出方式：根据模板导出.(考核导出)
            /// </summary>
            public const string CSettingAppraiseListUID = "04AA669F-4385-42ED-A7A1-15FCAFA8606E";
            /// <summary>
            /// 描述 -机票模板
            /// </summary>
            public const string CAirticketReserveFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8698E";
            /// <summary>
            /// 描述 -特殊岗位信息一览
            /// </summary>
            public const string CExpPositionInfoUID = "04AA669F-4385-42ED-A7A1-15FCAFA8602E";
            /// <summary>
            /// 描述 -职位信息一览
            /// </summary>
            public const string CParentStationInfoUID = "04AA669F-4385-42ED-A7A1-15FCAFA8607E";
            /// <summary>
            /// 描述 -职务信息一览
            /// </summary>
            public const string CPositionInfoUID = "04AA669F-4385-42ED-A7A1-15FCAFA8608E";
            /// <summary>
            /// 描述 -人员职位信息一览
            /// </summary>
            public const string CStaffStationIInfoUID = "04AA669F-4385-42ED-A7A1-15FCAFA8609E";
            /// <summary>
            /// 描述 -人员职务信息一览
            /// </summary>
            public const string CPerPositionTitleUID = "04AA669F-4385-42ED-A7A1-15FCAFA8610E";
            /// <summary>
            /// 描述 -人员任职资格信息一览
            /// </summary>
            public const string CStaffQualificationUID = "04AA669F-4385-42ED-A7A1-15FCAFA8611E";
            /// <summary>
            /// 描述 -招聘计划跟踪
            /// </summary>
            public const string CRecruitPlanTrackUID = "04AA669F-4385-42ED-A7A1-15FCAFA8612E";
            /// <summary>
            /// 描述 -员工证书导出摸板UID
            /// </summary>
            public const string CStaffCertificateFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8613E";
            /// <summary>
            /// 描述 -保险投保管理导出模板UID
            /// </summary>
            public const string CInsuranceFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8603E";
            /// <summary>
            /// 描述 -入职管理导出模板UID
            /// </summary>
            public const string CPersonEntryFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8614E";
            /// <summary>
            /// 描述 -调动统计模板UID
            /// </summary>
            public const string CTransferManageFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8617E";
            /// <summary>
            /// 描述 -离职统计模板UID
            /// </summary>
            public const string CDepartureManageFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8618E";
            /// <summary>
            /// 描述 -离职交接统计模板UID
            /// </summary>
            public const string CDimissionManageFlieUID = "04AA669F-4385-42ED-A7A1-15FCAFA8620E";
            /// <summary>
            /// 描述 -工资卡号统计模板UID
            /// </summary>
            public const string CSalaryNoManageFlieUID = "04aa669f-4385-42ed-a7a1-15fcafa8622e";
            /// <summary>
            /// 描述 -奖惩评优统计模板UID
            /// </summary>
            public const string CRewardsPunishManageFlieUID = "04aa669f-4385-42ed-a7a1-15fcafa8623e";
            /// <summary>
            /// 描述 -异动信息统计模板UID
            /// </summary>
            public const string CProbationManageFlieUID = "04AA669F-4385-42ED-A7A1-15FCAFA8624E";
            /// <summary>
            /// 描述 - 异动评价统计模板UID
            /// </summary>
            public const string CRegularEvaluateManageFlieUID = "04AA669F-4385-42ED-A7A1-15FCAFA8625E";
            /// <summary>
            /// 描述 - 员工生日统计模板UID
            /// </summary>
            public const string CStaffBirthdayFlieUID = "04aa669f-4385-42ed-a7a1-15fcafa8626e";
            /// <summary>
            /// 描述 - 外协合同模板UID
            /// </summary>
            public const string CVendorContractFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8627E";
            /// <summary>
            /// 描述 - 业务档案批量导入模板UID
            /// </summary>
            public const string CIndustryArchivesFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8630E";
            /// <summary>
            /// 描述 - 个人履历(中文)导出模板UID
            /// </summary>
            public const string CPersonInfoChineseFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8631E";
            /// <summary>
            /// 描述 - 个人履历(日文)导入模板UID
            /// </summary>
            public const string CPersonInfoJpFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8632E";
            /// <summary>
            /// 描述 - 个人履历(英文)导入模板UID
            /// </summary>
            public const string CPersonInfoEnglishFileUID = "04AA669F-4385-42ED-A7A1-15FCAFA8633E";
            /// <summary>
            /// 描述 - 任职资格信息导入模板UID
            /// </summary>
            public const string CQualificationUID = "04AA669F-4385-42ED-A7A1-15FCAFA8636E";
            /// <summary>
            /// 描述 - 外协员工考核导出模板UID
            /// </summary>
            public const string CVendorStaffEvaluateUID = "04AA669F-4385-42ED-A7A1-15FCAFA8699E";
            /// <summary>
            /// 描述 - 导出人员信息模板
            /// </summary>
            public const string CEStaffMessageUID = "04AA669F-4385-42ED-A7A1-15FCAFA8638E";
            /// <summary>
            /// 描述 - 日语证书统计分析模板
            /// </summary>
            public const string CJPNLanguageCFUID = "04AA669F-4385-42ED-A7A1-15FCAFA8799E";
            /// <summary>
            /// 描述 - 绩效目标进度统计模板
            /// </summary>
            public const string CExamineStatisticsA = "04AA669F-4385-42ED-0000-000000000000";
            /// <summary>
            /// 描述 - 绩效考核进度统计模板
            /// </summary>
            public const string CExamineStatisticsB = "04AA669F-4385-42ED-0000-000000000001";
            /// <summary>
            /// 描述 - 绩效考核结果一览
            /// </summary>
            public const string CExamineAppViewList = "04AA669F-4385-42ED-0000-000000000002";
            /// <summary>
            /// 描述 - 年终总结模板
            /// </summary>
            public const string CExamineYearDeferInfo = "04AA669F-4385-42ED-0000-000000000003";
            /// <summary>
            /// 描述 - 员工借调信息.xlsx
            /// </summary>
            public const string CBorrowStaffToDHCFile = "E9B78620-EB4A-4E37-A6EB-7DBDCCE689CE";
            /// <summary>
            /// 描述 - 外协人员信息一览表
            /// </summary>
            public const string CCooperationFileUID = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67657";
            /// <summary>
            /// 描述 - 绩效考核模板
            /// </summary>
            public const string CPETableIndicatorFileUID = "C8A115C6-6DB2-4F7F-B928-D31372892019";
            /// <summary>
            /// 描述 - 绩效考核指标统计
            /// </summary>
            public const string CIndicatorFileUID = "0F62943C-D823-42A8-92BF-6DCF3D05108D";
            /// <summary>
            /// 描述 - 导出证书分类信息模板
            /// </summary>
            public const string CCertificateInfoFileUID = "DD954525-2B3B-4DB3-828F-3F73821363C4";
            /// <summary>
            /// 描述 - 工资标准导出摸板UID
            /// </summary>
            public const string CWageStandardInfoFileUID = "C929B6EA-8E48-48F7-BC98-D710C086C996";
            /// <summary>
            /// 描述 - 入职管理导出模板UID
            /// </summary>
            public const string CPersonEntryDHCFileUID = "847350BA-1370-4ACA-94D0-6BD988EB328E";
            /// <summary>
            /// 描述 -  Offer统计数据表.xlsx
            /// </summary>
            public const string COfferFileUID = "8A3A54F0-1EA1-49BB-97E3-D7CB2533DBEF";
            /// <summary>
            /// 描述 - 员工任职资格延期申请一览模板
            /// </summary>
            public const string CStaffQualificationDeferFileUID = "0A869C3C-D3B5-4A8F-91D2-FC08A4C111C3";
            /// <summary>
            /// 描述 - 人才简历导出模板
            /// </summary>
            public const string CTalentInfoFileUID = "95F1990C-2C81-4485-B6CB-4D5B3FA2CA0D";
            /// <summary>
            /// 描述 - 面试官信息导出模板
            /// </summary>
            public const string CInterviewerStaffFileUID = "56d1f42a-ed80-4afd-8ccf-88ae1691f432";
            /// <summary>
            /// 描述 - 日本财产保险保单导出模板
            /// </summary>
            public const string CJapanInsuranceFileUID = "7B7C2A3F-ABED-4918-895C-A5B6A2A0B0AC";
            /// <summary>
            /// 描述 - 置装费导出模板
            /// </summary>
            public const string CSetEquipCostFileUID = "4A904D1D-8E0C-4CC4-BB11-015B904200BC";
            /// <summary>
            /// 招聘周期分析.xlsx.
            /// </summary>
            public const string CExportExcel1023 = "BE8D177C-8658-4E2A-AC6F-7B849DFCE3F8";
            /// <summary>
            /// 招聘周期按级别分析.xlsx
            /// </summary>
            public const string CExportExcel1023_1 = "BE8D177C-8658-4E2A-AC6F-7B849DFCE3F9";
            /// <summary>
            /// 
            /// </summary>
            public const string CExportExcel1023_2 = "BE8D177C-8658-4E2A-AC6F-7B849DFCE3F1";
            /// <summary>
            /// 招聘周期按级别分析首次对应.xlsx
            /// </summary>
            public const string CExportExcel1023_FE = "BE8D177C-8658-4E2A-AC6F-7B849DFCE1F2";
            /// <summary>
            /// 招聘周期按级别分析首次对应.xlsx
            /// </summary>
            public const string CExportExcel1023_FO = "BE8D177C-8658-4E2A-AC6F-7B849DFCE1F1";
            /// <summary>
            /// 描述 - 评审结果导出模板
            /// </summary>
            public const string CLineAppraisalResultFileUID = "DDDFD7C5-6EE8-4A96-B488-40EA97FCE5BC";
            /// <summary>
            /// Offer分析.xlsx
            /// </summary>
            public const string CExportExcel1024 = "C95058C0-07DA-481D-9CA4-22C51B3E2E20";
            /// <summary>
            /// 描述 - 离职共享信息导出模板
            /// </summary>
            public const string CLeaveDistrictDetialUID = "14006244-B826-448D-AF71-A5618F418946";

            //陈冰开始
            /// <summary>
            /// 描述 - 离职共享信息导出模板
            /// </summary>
            public const string CCoreStaffDetialUID = "4669DE93-B76F-47F7-972C-54B739545165";
            /// <summary>
            /// 描述 - 员工补贴信息导入模板
            /// </summary>
            public const string CStaffAllowanceFileUID = "72A9866D-B9CF-4D28-9DD1-437C48972FC5";
            /// <summary>
            /// 描述 - 院校信息导出模板
            /// </summary>
            public const string CUniversityInfo = "93D38CF9-9671-4E4E-9AE6-9F0D091F079D";

            /// <summary>
            /// 描述 - 护照信息导出模板
            /// </summary>
            public const string CPersonCertificate = "6FBDC861-B0AA-4A5E-AED4-BAAE26825224";

            /// <summary>
            /// 描述 - 导出员工证书最高级别摸板UID
            /// </summary>
            public const string CStaffCertificateBestFileUID = "D5D3E00F-6E9D-4679-B551-5041F8AB625F";
            /// <summary>
            /// 描述 - 学历
            /// </summary>
            public const string CDegreeLevel = "学历";
            /// <summary>
            /// 描述 - 外语
            /// </summary>
            public const string CForeignLanguage = "外语";
            /// <summary>
            /// 描述 - 技术
            /// </summary>
            public const string CArt = "技术";
            /// <summary>
            /// 描述 - 【需求岗位描述】
            /// </summary>
            public const string CRequestComment = "【需求岗位描述】";
            /// <summary>
            /// 处理状态(未处理)
            /// </summary>
            public const string CNotDealState = "01";
            /// <summary>
            /// 处理状态(已处理)
            /// </summary>
            public const string CDealState = "02";
            /// <summary>
            /// 离职结算单存放位置
            /// </summary>
            public const string CLeaveFileURL = "Images/DPark/LeaveFile/";
            /// <summary>
            /// 描述 - 人员信息导出模板UID(在职人员)
            /// </summary>
            public const string CStaffInfoPrint = "04AA669F-4385-42ED-A7A1-15FCAFA8616E";
            /// <summary>
            /// 描述 - 人员信息导出模板UID(包括在职和离职人员)
            /// </summary>
            public const string CALLStaffInfoPrint = "04AA669F-4385-42ED-A7A1-15FCAFA8615E";
            /// <summary>
            /// 开发资源经理
            /// </summary>
            public const string CSourceManager = "00000000-0000-0000-0001-000000000190";
            /// <summary>
            /// 毕业生需求统计模板
            /// </summary>
            public const string CSchoolRecruitRequestUID = "04AA669F-4385-42ED-A7A1-15FCAFA8619E";
            /// <summary>
            /// 技术者简历模板
            /// </summary>
            public const string CRESUMEFILEUID = "04AA669F-4385-42ED-A7A1-15FCAFA8621E";
            /// <summary>
            /// 是否标志:是
            /// </summary>
            public const string CIsNotFlgYes = "是";
            /// <summary>
            /// 是否标志:否
            /// </summary>
            public const string CIsNotFlgNO = "否";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CAttribuateManageTime = "属性开始日期和属性结束日期不合逻辑...";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CParentNotExistManage = "指定的上级不存在、";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CStaffNotExistManage = "指定的负责人不存在、";
            public const string CAccNotExistManage = "指定的帐套不存在、";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CCostNotExistManage = "指定的成本中心不存在、";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CStaffInstateDateManage = "【{0}】员工任职有效期间与前一任职有效期间冲突，请确认！";
            /// <summary>
            /// 描述 - 错误Msg
            /// </summary>
            public const string CStaffPositionDateManage = "【{0}】员工兼职任命有效期间不在主职任命有效期间内，请确认！";
            /// <summary>
            /// 描述 - 试用期限
            /// </summary>
            public const string CTryPeriod = "3";
            /// <summary>
            ///  描述 - 大连华信计算机技术股份有限公司
            /// </summary>
            public const string COldCompany01 = "Org_1";
            /// <summary>
            /// 描述 - 大连华信软件园物业管理有限公司
            /// </summary>
            public const string COldCompany02 = "Org_272";
            /// <summary>
            /// 描述 - 七月一日
            /// </summary>
            public const string CDominionDay = "0701";
            /// <summary>
            /// 描述 - 大连华信计算机技术股份有限公司
            /// </summary>
            public const string COldCostCenter01 = "Coc_96";
            /// <summary>
            /// 描述 - 证书等级中为英语的节点
            /// </summary>
            public const string CCertificateCodeA = "1010";
            /// <summary>
            /// 描述 - 证书等级中为日语的节点
            /// </summary>
            public const string CCertificateCodeB = "1020";
            /// <summary>
            /// 描述 - 证书等级中为其他的节点
            /// </summary>
            public const string CCertificateCodeC = "1040";
            /// <summary>
            /// 描述 - 证书等级中为语言类的节点
            /// </summary>
            public const string CCertificateCodeD = "10";
            /// <summary>
            /// 描述 - 管理员StaffUID
            /// </summary>
            public const string CAdminStaffUID = "10000000-0000-0000-9999-000000009610";
            /// <summary>
            /// 根证书UID
            /// </summary>
            public const string CParentUID = "99999999-9999-9999-9999-999999999999";
            /// <summary>
            /// 外协公司编码前缀
            /// </summary>
            public const string CVendorCodePrefix = "W";
            //没有注释
            public const string CFileCoumItem01 = "身份证复印件";
            public const string CFileCoumItem02 = "学历证明复印件";
            public const string CFileCoumItem03 = "学位证明复印件";
            public const string CFileCoumItem04 = "外语等级证书复印件";
            public const string CFileCoumItem05 = "户口复印件";
            public const string CFileCoumItem06 = "体检报告";
            public const string CFileCoumItem07 = "保密协议";
            public const string CFileCoumItem08 = "个人信息使用授权书";
            public const string CFileCoumItem09 = "入职承诺书";
            public const string CFileCoumItem10 = "解除劳动合同证明书或失业证";
            /// <summary>
            /// 无任命的职位ID
            /// </summary>
            public const string CParentStationNo = "Sta_78";
            /// <summary>
            /// 无任命的职位名称
            /// </summary>
            public const string CParentStationNoName = "无任命";
            /// <summary>
            /// 设备管理员的职位ID
            /// </summary>
            public const string CEquipManager = "Sta_76";
            /// <summary>
            /// 软件管理员的职位ID
            /// </summary>
            public const string CSoftWareManager = "Epi_4";
            /// <summary>
            /// 网络管理员的职位ID
            /// </summary>
            public const string CNetWorkManager = "Epi_1";
            /// <summary>
            /// 部门助理的职位ID
            /// </summary>
            public const string CDeptAssistant = "Sta_217";
            /// <summary>
            /// 实习生职位的职位ID
            /// </summary>
            public const string CPractice = "Sta_238";
            /// <summary>
            /// 华信帐套UID
            /// </summary>
            public const string CDHCAccUID = "00000000-0000-0000-0000-000000000001";
            /// <summary>
            /// 永道帐套UID
            /// </summary>
            public const string CYonderAccUID = "00000000-0000-0000-0000-000000000009";
            /// <summary>
            /// 中信帐套UID
            /// </summary>
            public const string CCiticAccUID = "00000000-0000-0000-0000-000000000011";
            /// <summary>
            /// 华信帐套事业部HR岗位UID
            /// </summary>
            public const string CDHCGroupHRStationInfoUID = "00000000-0000-0000-0001-000000000091";
            /// <summary>
            /// 离职共享查询画面权限UID
            /// </summary>
            public const string CLeaveDistrictDetialRoleUID = "EC030900-BCAB-4F9C-9891-169767719944";


            /// <summary>
            /// 离职共享查询画面权限UID
            /// </summary>
            public const string CRequireShareManageRoleUID = "44B6D387-ADC2-4C48-94EC-44FD0D6C1CC8";

            /// <summary>
            /// 人力资源部UID. 2014-04-27 Add By Lsq
            /// </summary>
            public const string CHRDeptUID = "00000000-0000-0000-0000-000000000042";
            /// <summary>
            ///  工资架构（总额名称）
            /// </summary>
            public const string CSalarySumName = "工资总额";
            /// <summary>
            ///  任职资格 是
            /// </summary>
            public const string CBoolTrue = "01";
            /// <summary>
            /// 任职资格 非
            /// </summary>
            public const string CBoolFalse = "02";
            /// <summary>
            /// 是免审
            /// </summary>
            public const string CMaterialNotCheck = "01";
            /// <summary>
            /// 非免审
            /// </summary>
            public const string CMaterialCheck = "02";
            /// <summary>
            /// 模板 课件达成结果.xls
            /// </summary>
            public const string CCoursewareReachedUID = "0427A36F-7104-4710-AF66-6E0D2173A42B";
            /// <summary>
            /// 模板 项目评估报告达成结果.xls
            /// </summary>
            public const string CEstimateReachedUID = "0427A36F-7104-4710-AF66-6E0D2173A43B";
            /// <summary>
            /// 模板 线下评审结果.xls
            /// </summary>
            public const string CLineResultUID = "0427A36F-7104-4710-AF66-6E0D2173A44B";
            /// <summary>
            /// 模板 综合评审结果.xls
            /// </summary>
            public const string CMeettingResultUID = "0427A36F-7104-4710-AF66-6E0D2173A45B";
            /// <summary>
            /// 模板 任职资格申请名单.xls
            /// </summary>
            public const string CQualificationApply = "82414A30-0F07-4B93-AFCB-2979442E05EB";
            /// <summary>
            /// 模板 任职资格汇总.xls
            /// </summary>
            public const string CQualificationTotalInfo = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67645";
            /// <summary>
            /// 模板 任职资格项目管理论文评分信息.xls
            /// </summary>
            public const string CQualificationLineAppraisalInfo = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67653";
            /// <summary>
            /// 模板 任职资格打包下载.xls
            /// </summary>
            public const string CDownLoadViewListUID = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67654";

            /// <summary>
            /// 模板 任职资格到期续延工作总结.doc
            /// </summary>
            public const string CQualificationDeferInfo = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67646";
            /// <summary>
            /// 模板 项目管理类(个人信息表).xls
            /// </summary>
            public const string CPMPersonInfo = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67647";
            /// <summary>
            /// 模板 技术类(个人信息表).xls
            /// </summary>
            public const string CTECPersonInfo = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67648";
            /// <summary>
            /// 模板 质量管理类(个人信息表).xls
            /// </summary>
            public const string CQMPersonInfo = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67649";
            /// <summary>
            /// 模板 职位任命对接表.xls
            /// </summary>
            public const string CQualificationStation = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67655";
            /// <summary>
            /// 模板 新生成任职资格的人员信息.xls
            /// </summary>
            public const string CQualificationApprovalResult = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67656";
            /// <summary>
            /// 模板 简历导入状况.xls
            /// </summary>
            public const string CTalentInfoImport = "A7847A3D-12F1-4A0F-B8D0-E6CFBCA67652";
            /// <summary>
            /// 英语级别
            /// </summary>
            public const string CEnglishLevel = "英语级别";
            /// <summary>
            /// 英语四级
            /// </summary>
            public const string CEnglishLevel4 = "英语四级";
            /// <summary>
            /// 英语六级
            /// </summary>
            public const string CEnglishLevel6 = "英语六级";
            /// <summary>
            /// 专业四级
            /// </summary>
            public const string CEnglishLevel4L = "专业四级";
            /// <summary>
            /// 专业八级
            /// </summary>
            public const string CEnglishLevel8L = "专业八级";
            /// <summary>
            /// 日语等级
            /// </summary>
            public const string CJpnLanguageLevel = "日语等级";
            /// <summary>
            /// 一级
            /// </summary>
            public const string CJpnLanguageLevel1 = "一级";
            /// <summary>
            /// 二级
            /// </summary>
            public const string CJpnLanguageLevel2 = "二级";
            /// <summary>
            /// 三级
            /// </summary>
            public const string CJpnLanguageLevel3 = "三级";
            /// <summary>
            /// 四级
            /// </summary>
            public const string CJpnLanguageLevel4 = "四级";
            /// <summary>
            /// 未婚
            /// </summary>
            public const string CMarriageFlag1 = "未婚";
            /// <summary>
            /// 已婚
            /// </summary>
            public const string CMarriageFlag2 = "已婚";
            /// <summary>
            /// 政治面貌
            /// </summary>
            public const string CPolityVisageCode = "政治面貌";
            /// <summary>
            /// 中共党员
            /// </summary>
            public const string CPolityVisageCode1 = "中共党员";
            /// <summary>
            /// 中共团员
            /// </summary>
            public const string CPolityVisageCode2 = "中共团员";
            /// <summary>
            /// 群众
            /// </summary>
            public const string CPolityVisageCode3 = "群众";
            /// <summary>
            /// 民主党派
            /// </summary>
            public const string CPolityVisageCode4 = "民主党派";
            /// <summary>
            /// 无党派人士
            /// </summary>
            public const string CPolityVisageCode5 = "无党派人士";
            /// <summary>
            /// 男
            /// </summary>
            public const string CMale = "男";
            /// <summary>
            /// 女
            /// </summary>
            public const string CLady = "女";

            public const string C572 = "572";
            /// <summary>
            /// 外协专员评价
            /// </summary>
            public const string CVendoEvaluate = "01";
            /// <summary>
            /// 信息安全评价
            /// </summary>
            public const string CInforEvaluate = "Other02";
            /// <summary>
            /// 项目评价(部门经理）
            /// </summary>
            public const string CProjeEvaluate = "Other01";
            /// <summary>
            /// 项目评价(委托人)
            /// </summary>
            public const string CProjeEvaluateAl = "Other04";
            /// <summary>
            /// 部门经理
            /// </summary>
            public const string CRoleMana = "01";
            /// <summary>
            /// 信息安全主管
            /// </summary>
            public const string CRoleInfo = "02";
            /// <summary>
            /// 事业部总
            /// </summary>
            public const string CRoleGrou = "03";
            /// <summary>
            /// 普通被委托员工
            /// </summary>
            public const string CRoleEmpl = "04";
            /// <summary>
            /// 任职资格资料
            /// </summary>
            public const string CQualicationFile = "任职资格资料";
            /// <summary>
            /// 中期绩效
            /// </summary>
            public const string CMiddlePE = "中期绩效";
            /// <summary>
            /// 审批未开始
            /// </summary>
            public const string CStateNotStart = "审批未开始";

            public const string CQmessage = "该员工本次主题申请的任职资格已被该员工撤销，此次重新给员工申请任职资格信息！";
            /// <summary>
            /// 外语能力
            /// </summary>
            public const string CLanguageAbility = "外语能力";
            /// <summary>
            /// 工作经验
            /// </summary>
            public const string CWorkExperience = "工作经验";
            /// <summary>
            /// 资质证书
            /// </summary>
            public const string CQLicense = "资质证书";
            /// <summary>
            /// 培训要求
            /// </summary>
            public const string CTrainRequire = "培训要求";
            /// <summary>
            /// 
            /// </summary>
            public const string CPEMsg = "近一期绩效考核结果为优秀及以上员工，可以进行晋升任职资格申请；近一期绩效考核结果为胜任及以上的员工，可以进行平级任职资格申请";
            /// <summary>
            /// 胜任以上
            /// </summary>
            public const string CPEGradeUpC = "胜任以上";
            /// <summary>
            /// 本人自己取消此次任职资格
            /// </summary>
            public const string CCancelQualification = "本人自己取消此次任职资格";
            /// <summary>
            /// 任职资格专员变更任职资格信息
            /// </summary>
            public const string CQualiApplyRemark = "任职资格专员变更任职资格信息";
            /// <summary>
            /// 上传
            /// </summary>
            public const string CUpload = "上传";
            /// <summary>
            /// 人
            /// </summary>
            public const string CPerson = "人";
            /// <summary>
            /// 场
            /// </summary>
            public const string CField = "场";
            /// <summary>
            /// 日期
            /// </summary>
            public const string CDateTime = "日期";
            /// <summary>
            /// 时间
            /// </summary>
            public const string CTime = ",时间";
            /// <summary>
            /// 评审地点
            /// </summary>
            public const string CReviewPlace = ",评审地点";
            /// <summary>
            /// 上传文件原名
            /// </summary>
            public const string CUploadFileName = "上传文件原名";
            /// <summary>
            /// 正常申请
            /// </summary>
            public const string CFormalApply = "正常申请";
            /// <summary>
            /// 特殊申请
            /// </summary>
            public const string CSpecialApply = "特殊申请";
            /// <summary>
            /// false
            /// </summary>
            public const string CFalse = "false";
            /// <summary>
            /// true
            /// </summary>
            public const string CTrue = "true";
            /// <summary>
            /// 打包成功
            /// </summary>
            public const string CPickSuccess = "打包成功";
            /// <summary>
            /// 打包失败
            /// </summary>
            public const string CPickFail = "打包失败";
            /// <summary>
            /// 员工卡号
            /// </summary>
            public const string CStaffCode = "员工卡号";
            /// <summary>
            /// 员工名称
            /// </summary>
            public const string CStaffName = "员工名称";
            /// <summary>
            /// 总分
            /// </summary>
            public const string CTotalResult = "总分";
            /// <summary>
            /// 提交日期
            /// </summary>
            public const string CResultDate = "提交日期";
            /// <summary>
            /// 备注
            /// </summary>
            public const string CRemark = "备注";
            /// <summary>
            /// 从{0}年度主题复制到{1}年度
            /// </summary>
            public const string CSth = "从{0}年度主题复制到{1}年度";
            /// <summary>
            /// 员工【{0}：{1}】 已于 【{2}】发送过请求评价邮件。
            /// </summary>
            public const string CArr = "员工【{0}：{1}】 已于 【{2}】发送过请求评价邮件。";
            /// <summary>
            /// 免审
            /// </summary>
            public const string CMaterial = "免审";
            /// <summary>
            /// 语言
            /// </summary>
            public const string CLanguage = "语言";
            /// <summary>
            /// 绩效
            /// </summary>
            public const string CPE = "绩效";
            /// <summary>
            /// 业务能力
            /// </summary>
            public const string CBusinessAbility = "业务能力";
            /// <summary>
            /// 接受培训
            /// </summary>
            public const string CAcceptTrain = "接受培训";
            /// <summary>
            /// 持有证书
            /// </summary>
            public const string CHasLicense = "持有证书";
            /// <summary>
            /// 通过
            /// </summary>
            public const string CPass = "通过";
            /// <summary>
            /// 未通过
            /// </summary>
            public const string CUnpass = "未通过";
            /// <summary>
            /// 无需安排
            /// </summary>
            public const string CNeedNotArrange = "无需安排";
            /// <summary>
            /// 不需要
            /// </summary>
            public const string CNoNeed = "不需要";
            /// <summary>
            /// 不安排
            /// </summary>
            public const string CNoArrange = "不安排";
            /// <summary>
            /// 未安排
            /// </summary>
            public const string CNotArrange = "未安排";
            /// <summary>
            /// 已安排
            /// </summary>
            public const string CAlreadyArrange = "已安排";
            /// <summary>
            /// 导入
            /// </summary>
            public const string CImport = "导入";
            /// <summary>
            /// 提交
            /// </summary>
            public const string CSubmit = "提交";
            /// <summary>
            /// 无要求
            /// </summary>
            public const string CNoRequest = "无要求";
            /// <summary>
            /// 入力
            /// </summary>
            public const string CInput = "入力";
            /// <summary>
            /// 设定是否具有免审证书
            /// </summary>
            public const string CHasCe = "HasCe";
            /// <summary>
            /// 是否具有有效的技术文档
            /// </summary>
            public const string CHasQuaHistory = "HasQuaHistory";
            /// <summary>
            /// 是否需要综合评审
            /// </summary>
            public const string CNeedMeetting = "NeedMeetting";
            /// <summary>
            /// 需要
            /// </summary>
            public const string CNeed = "需要";
            /// <summary>
            /// 线下
            /// </summary>
            public const string CLine = "线下";
            /// <summary>
            /// 综合
            /// </summary>
            public const string CMeetting = "综合";

            public const string CFileForQua = "关于技术方案如有任何问题请联系{0}，项目管理论文请联系{1}。或与您的事业部HR直接联系。请在{2}前与相关人员沟通。";
            /// <summary>
            /// 持有的项目管理类证书
            /// </summary>
            public const string CHasPMLicense = "持有的项目管理类证书：";
            /// <summary>
            /// 提交材料
            /// </summary>
            public const string CSubmitFiles = "提交材料";
            /// <summary>
            /// 其它说明
            /// </summary>
            public const string COtherNotes = "其它说明：";
            /// <summary>
            /// 日期格式(yyyyMMdd)
            /// </summary>
            public const string CDateFormat = "yyyyMMdd";
            /// <summary>
            /// 综合评审结果未发布
            /// </summary>
            public const string CMeettingOperate = " ;综合评审结果 ： 未发布";
            /// <summary>
            /// 综合评审结果已发布
            /// </summary>
            public const string CMeettingOperateOK = " ;综合评审结果 ： 已发布";
            /// <summary>
            /// 线下评审结果未发布
            /// </summary>
            public const string CLineOperate = "线下评审结果 ： 未发布 ";
            /// <summary>
            /// 线下评审结果已发布
            /// </summary>
            public const string CLineOperateOK = "线下评审结果 ： 已发布 ";
            /// <summary>
            /// 线下(line)
            /// </summary>
            public const string CLineLabel = "line";
            /// <summary>
            /// 综合(meetting)
            /// </summary>
            public const string CMeettingLabel = "meetting";
            /// <summary>
            /// 招聘需求编号
            /// </summary>
            public const string CRequireNo = "0001";
            /// <summary>
            /// 集团各公司人员类别及年限、学历情况汇总
            /// </summary>
            public const string CExportExcel0001 = "04AA669F-4385-42ED-A7A1-15FCA010001E";
            /// <summary>
            /// 各部门外协人员状况
            /// </summary>
            public const string CExportExcel0002 = "04AA669F-4385-42ED-A7A1-15FCA010002E";
            /// <summary>
            /// 事业部人员类别
            /// </summary>
            public const string CExportExcel0003 = "04AA669F-4385-42ED-A7A1-15FCA010003E";
            /// <summary>
            /// 人员类别月度增长情况
            /// </summary>
            public const string CExportExcel0004 = "04AA669F-4385-42ED-A7A1-15FCA010004E";
            /// <summary>
            /// 个事业部和分子公司人员增长情况
            /// </summary>
            public const string CExportExcel0005 = "04AA669F-4385-42ED-A7A1-15FCA010005E";
            /// <summary>
            /// 集团各级别月度增长状况
            /// </summary>
            public const string CExportExcel0006 = "04AA669F-4385-42ED-A7A1-15FCA010006E";
            /// <summary>
            /// 集团各月份入离职人员类别状况
            /// </summary>
            public const string CExportExcel0007 = "04AA669F-4385-42ED-A7A1-15FCA010007E";
            /// <summary>
            /// 集团各事业部入离职月度人员类别状况
            /// </summary>
            public const string CExportExcel0008 = "04AA669F-4385-42ED-A7A1-15FCA010008E";
            /// <summary>
            /// 集团月度各人员类别事业部入职状况
            /// </summary>
            public const string CExportExcel0009 = "04AA669F-4385-42ED-A7A1-15FCA010009E";
            /// <summary>
            /// 集团各公司月度人员情况
            /// </summary>
            public const string CExportExcel0010 = "04AA669F-4385-42ED-A7A1-15FCA010010E";
            /// <summary>
            /// 月度劳动合同续签情况
            /// </summary>
            public const string CExportExcel0011 = "04AA669F-4385-42ED-A7A1-15FCA010011E";
            /// <summary>
            /// 华信本部月度新增人员详细
            /// </summary>
            public const string CExportExcel0012 = "04AA669F-4385-42ED-A7A1-15FCA010012E";
            /// <summary>
            /// 集团各公司间接人员占比及职能人员占比
            /// </summary>
            public const string CExportExcel0013 = "04AA669F-4385-42ED-A7A1-15FCA010013E";
            /// <summary>
            /// 集团部门入离职汇总
            /// </summary>
            public const string CExportExcel0014 = "04AA669F-4385-42ED-A7A1-15FCA010014E";
            /// <summary>
            /// 集团月份正式员工入职明细
            /// </summary>
            public const string CExportExcel0015 = "04AA669F-4385-42ED-A7A1-15FCA010015E";
            /// <summary>
            /// 集团月份实际离职详细
            /// </summary>
            public const string CExportExcel0016 = "04AA669F-4385-42ED-A7A1-15FCA010016E";
            /// <summary>
            /// 集团本月预计离职详细
            /// </summary>
            public const string CExportExcel0017 = "04AA669F-4385-42ED-A7A1-15FCA010017E";
            /// <summary>
            /// 各部门月度人数汇总
            /// </summary>
            public const string CExportExcel0019 = "04AA669F-4385-42ED-A7A1-15FCA010019E";
            /// <summary>
            /// 去年-今年各月份人数对比
            /// </summary>
            public const string CExportExcel0020 = "04AA669F-4385-42ED-A7A1-15FCA010020E";
            /// <summary>
            /// 部门各级别人数汇总
            /// </summary>
            public const string CExportExcel0021 = "04AA669F-4385-42ED-A7A1-15FCA010021E";
            /// <summary>
            /// 各部门男女比例
            /// </summary>
            public const string CExportExcel0022 = "04AA669F-4385-42ED-A7A1-15FCA010022E";
            /// <summary>
            /// 各部门年龄分布
            /// </summary>
            public const string CExportExcel0023 = "04AA669F-4385-42ED-A7A1-15FCA010023E";
            /// <summary>
            /// 各部门社龄分布
            /// </summary>
            public const string CExportExcel0024 = "04AA669F-4385-42ED-A7A1-15FCA010024E";
            /// <summary>
            /// 各部门工龄分布
            /// </summary>
            public const string CExportExcel0025 = "04AA669F-4385-42ED-A7A1-15FCA010025E";
            /// <summary>
            /// 各部门职位汇总
            /// </summary>
            public const string CExportExcel0026 = "04AA669F-4385-42ED-A7A1-15FCA010026E";
            /// <summary>
            /// 各部门职位分布
            /// </summary>
            public const string CExportExcel0027 = "04AA669F-4385-42ED-A7A1-15FCA010027E";
            /// <summary>
            /// 各部门日语能力汇总
            /// </summary>
            public const string CExportExcel0028 = "04AA669F-4385-42ED-A7A1-15FCA010028E";
            /// <summary>
            /// 各月人员异动汇总
            /// </summary>
            public const string CExportExcel0029 = "04AA669F-4385-42ED-A7A1-15FCA010029E";
            /// <summary>
            /// 历年同期离职对比
            /// </summary>
            public const string CExportExcel0030 = "04AA669F-4385-42ED-A7A1-15FCA010030E";
            /// <summary>
            /// 各部门离职分析
            /// </summary>
            public const string CExportExcel0031 = "04AA669F-4385-42ED-A7A1-15FCA010031E";
            /// <summary>
            /// 离职基础数据
            /// </summary>
            public const string CExportExcel0040 = "04AA669F-4385-42ED-A7A1-15FCA010040E";
            /// <summary>
            /// 各月离职人数
            /// </summary>
            public const string CExportExcel0041 = "04AA669F-4385-42ED-A7A1-15FCA010041E";
            /// <summary>
            /// 离职原因分析
            /// </summary>
            public const string CExportExcel0042 = "04AA669F-4385-42ED-A7A1-15FCA010042E";
            /// <summary>
            /// 事业部和部门离职率
            /// </summary>
            public const string CExportExcel0043 = "04AA669F-4385-42ED-A7A1-15FCA010043E";
            /// <summary>
            /// 离职员工级别分布
            /// </summary>
            public const string CExportExcel0044 = "04AA669F-4385-42ED-A7A1-15FCA010044E";
            /// <summary>
            /// 级别分布--合并版
            /// </summary>
            public const string CExportExcel0045 = "04AA669F-4385-42ED-A7A1-15FCA010045E";
            /// <summary>
            /// 离职员工社龄分布
            /// </summary>
            public const string CExportExcel0046 = "04AA669F-4385-42ED-A7A1-15FCA010046E";
            /// <summary>
            /// 离职员工工龄分布
            /// </summary>
            public const string CExportExcel0047 = "04AA669F-4385-42ED-A7A1-15FCA010047E";
            /// <summary>
            /// 往年各月离职率对比
            /// </summary>
            public const string CExportExcel0048 = "04AA669F-4385-42ED-A7A1-15FCA010048E";
            /// <summary>
            /// 往年同期离职对比
            /// </summary>
            public const string CExportExcel0049 = "04AA669F-4385-42ED-A7A1-15FCA010049E";
            /// <summary>
            /// 各组织各月底人数
            /// </summary>
            public const string CExportExcel0050 = "04AA669F-4385-42ED-A7A1-15FCA010050E";
            /// <summary>
            /// 各组织各月平均人数
            /// </summary>
            public const string CExportExcel0051 = "04AA669F-4385-42ED-A7A1-15FCA010051E";
            /// <summary>
            /// 各月离职员工类别分布
            /// </summary>
            public const string CExportExcel0052 = "04AA669F-4385-42ED-A7A1-15FCA010052E";
            /// <summary>
            /// 各月离职员工工龄分布
            /// </summary>
            public const string CExportExcel0053 = "04AA669F-4385-42ED-A7A1-15FCA010053E";
            /// <summary>
            /// 各月离职员工社龄分布
            /// </summary>
            public const string CExportExcel0054 = "04AA669F-4385-42ED-A7A1-15FCA010054E";
            /// <summary>
            /// 各月离职员工级别分布
            /// </summary>
            public const string CExportExcel0055 = "04AA669F-4385-42ED-A7A1-15FCA010055E";
            /// <summary>
            /// 各月离职原因分布
            /// </summary>
            public const string CExportExcel0056 = "04AA669F-4385-42ED-A7A1-15FCA010056E";
            /// <summary>
            /// 各月部门离职员工分布
            /// </summary>
            public const string CExportExcel0057 = "04AA669F-4385-42ED-A7A1-15FCA010057E";
            /// <summary>
            /// 离职员工绩效分布
            /// </summary>
            public const string CExportExcel0058 = "04AA669F-4385-42ED-A7A1-15FCA010058E";
            /// <summary>
            /// 离职员工绩效级别占比
            /// </summary>
            public const string CExportExcel0059 = "04AA669F-4385-42ED-A7A1-15FCA010059E";
            /// <summary>
            /// 各部门离职员工涨薪状况
            /// </summary>
            public const string CExportExcel0060 = "04AA669F-4385-42ED-A7A1-15FCA010060E";
            /// <summary>
            /// 各部门降薪离职员工占比
            /// </summary>
            public const string CExportExcel0061 = "04AA669F-4385-42ED-A7A1-15FCA010061E";
            /// <summary>
            /// 离职去向统计
            /// </summary>
            public const string CExportExcel0062 = "04AA669F-4385-42ED-A7A1-15FCA010062E";
            /// <summary>
            /// 各部门离职原因分布
            /// </summary>
            public const string CExportExcel0063 = "04AA669F-4385-42ED-A7A1-15FCA010063E";
            /// <summary>
            /// 离职员工招聘方式和级别分布
            /// </summary>
            public const string CExportExcel0064 = "04AA669F-4385-42ED-A7A1-15FCA010064E";
            /// <summary>
            /// 各部门不同级别淘汰人员分布
            /// </summary>
            public const string CExportExcel0065 = "04AA669F-4385-42ED-A7A1-15FCA010065E";
            /// <summary>
            /// 各部门核心员工离职占比
            /// </summary>
            public const string CExportExcel0066 = "04AA669F-4385-42ED-A7A1-15FCA010066E";
            /// <summary>
            /// 年度招聘需求完成情况
            /// </summary>
            public const string CExportExcel1001 = "04AA669F-4385-42ED-A7A1-15FCA011001E";
            /// <summary>
            /// 月度入职状况
            /// </summary>
            public const string CExportExcel1002 = "04AA669F-4385-42ED-A7A1-15FCA011002E";
            /// <summary>
            /// 入职人员级别状况
            /// </summary>
            public const string CExportExcel1003 = "04AA669F-4385-42ED-A7A1-15FCA011003E";
            /// <summary>
            /// 招聘渠道入职人员状况
            /// </summary>
            public const string CExportExcel1004 = "04AA669F-4385-42ED-A7A1-15FCA011004E";
            /// <summary>
            /// 来源公司状况
            /// </summary>
            public const string CExportExcel1005 = "04AA669F-4385-42ED-A7A1-15FCA011005E";
            /// <summary>
            /// 入职人员各级别招聘来源统计
            /// </summary>
            public const string CExportExcel1006 = "04AA669F-4385-42ED-A7A1-15FCA011006E";
            /// <summary>
            /// 各事业部推荐通过率
            /// </summary>
            public const string CExportExcel1007 = "04AA669F-4385-42ED-A7A1-15FCA011007E";
            /// <summary>
            /// 年度校园招聘入职统计
            /// </summary>
            public const string CExportExcel1008 = "04AA669F-4385-42ED-A7A1-15FCA011008E";
            /// <summary>
            /// 年度招聘人员类别统计
            /// </summary>
            public const string CExportExcel1009 = "04AA669F-4385-42ED-A7A1-15FCA011009E";
            /// <summary>
            /// 校园招聘人员专业状况
            /// </summary>
            public const string CExportExcel1010 = "04AA669F-4385-42ED-A7A1-15FCA011010E";
            /// <summary>
            /// 进行中招聘周期需求跟踪
            /// </summary>
            public const string CExportExcel1011 = "04AA669F-4385-42ED-A7A1-15FCA011011E";
            /// <summary>
            /// 绩效级别占比
            /// </summary>
            public const string CExportExcel2001 = "04AA669F-4385-42ED-A7A1-15FCA012001E";
            /// <summary>
            /// 华信本部各部门绩效各等级占比
            /// </summary>
            public const string CExportExcel2002 = "04AA669F-4385-42ED-A7A1-15FCA012002E";
            /// <summary>
            /// 华信本部绩效招聘方式占比
            /// </summary>
            public const string CExportExcel2003 = "04AA669F-4385-42ED-A7A1-15FCA012003E";
            /// <summary>
            /// 华信本部绩效毕业院校批次占比
            /// </summary>
            public const string CExportExcel2004 = "04AA669F-4385-42ED-A7A1-15FCA012004E";
            /// <summary>
            /// 华信本部绩效工龄段占比
            /// </summary>
            public const string CExportExcel2005 = "04AA669F-4385-42ED-A7A1-15FCA012005E";
            /// <summary>
            /// 华信本部绩效毕业院校占比
            /// </summary>
            public const string CExportExcel2006 = "04AA669F-4385-42ED-A7A1-15FCA012006E";
            /// <summary>
            /// 集团各任职资格年度对比
            /// </summary>
            public const string CExportExcel3009 = "04AA669F-4385-42ED-A7A1-15FCA013009E";
            /// <summary>
            /// 集团年度任职资格变动统计(新增)
            /// </summary>
            public const string CExportExcel3010 = "04AA669F-4385-42ED-A7A1-15FCA013010E";
            /// <summary>
            /// 集团年度任职资格变动统计(晋升)
            /// </summary>
            public const string CExportExcel3011 = "04AA669F-4385-42ED-A7A1-15FCA013011E";
            /// <summary>
            /// 集团任职资格持有总数量统计
            /// </summary>
            public const string CExportExcel3012 = "04AA669F-4385-42ED-A7A1-15FCA013012E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel3013 = "04AA669F-4385-42ED-A7A1-15FCA013013E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel1015 = "04AA669F-4385-42ED-A7A1-15FCA011015E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel1016 = "04AA669F-4385-42ED-A7A1-15FCA011016E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel1017 = "04AA669F-4385-42ED-A7A1-15FCA011017E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel1018 = "04AA669F-4385-42ED-A7A1-15FCA011018E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel1019 = "04AA669F-4385-42ED-A7A1-15FCA011019E";
            /// <summary>
            /// 集团任职资格持有占比统计
            /// </summary>
            public const string CExportExcel1020 = "04AA669F-4385-42ED-A7A1-15FCA011020E";
            /// <summary>
            /// 各部门离职分析
            /// </summary>
            public const string CExportExcel4001 = "04AA669F-4385-42ED-A7A1-15FCA014001E";
            /// <summary>
            /// 计划与实际对比
            /// </summary>
            public const string CExportExcel4002 = "04AA669F-4385-42ED-A7A1-15FCA014002E";

            /// <summary>
            /// 集团年度任命人数统计表
            /// </summary>
            public const string CExportExcel3001 = "04AA669F-4385-42ED-A7A1-15FCA013001E";
            /// <summary>
            /// 集团年度任命变动统计(新增、撤销、离职)
            /// </summary>
            public const string CExportExcel3002 = "04AA669F-4385-42ED-A7A1-15FCA013002E";
            /// <summary>
            /// 集团年度任命变动统计(升、降、转)
            /// </summary>
            public const string CExportExcel3003 = "04AA669F-4385-42ED-A7A1-15FCA013003E";
            /// <summary>
            /// 招聘渠道分析
            /// </summary>
            public const string CExportExcel1021 = "BE8D177C-8658-4E2A-AC6F-7B849DFCE3F6";
            /// <summary>
            /// 面试官分析
            /// </summary>
            public const string CExportExcel1022 = "BE8D177C-8658-4E2A-AC6F-7B849DFCE3F7";
        }
        #endregion

        #region  流程编码.
        /// <summary>
        /// 流程编码.
        /// </summary>
        public class ExFlow
        {
            /// <summary>
            /// 流程编码 -员工转正
            /// </summary>
            public const string CStaffTurn = "049";
            /// <summary>
            /// 流程编码 - 合同续签
            /// </summary>
            public const string CCompactContinue = "050";
            /// <summary>
            /// 流程编码 - 证件借用
            /// </summary>
            public const string CCertificateBorrow = "051";
            /// <summary>
            /// 流程编码 - 人员调动
            /// </summary>
            public const string CStaffRedeploy = "052";
            /// <summary>
            /// 流程编码 - 工作交接
            /// </summary>
            public const string CWorkConnect = "053";
            /// <summary>
            /// 流程编码 - 人员离职
            /// </summary>
            public const string CStaffDimission = "054";
            /// <summary>
            /// 流程编码 - 离职交接
            /// </summary>
            public const string CDimissionConnect = "055";
            /// <summary>
            /// 流程编码 - 中途招聘需求
            /// </summary>
            public const string CMidwayRecruitDemand = "056";
            /// <summary>
            /// 流程编码 - 校园招聘需求
            /// </summary>
            public const string CCampusRecruitDemand = "057";
            /// <summary>
            /// 流程编码 - 校园招聘计划
            /// </summary>
            public const string CCampusRecruitPlan = "058";
            /// <summary>
            /// 流程编码 - 外协公司需求
            /// </summary>
            public const string CVendorDemand = "059";
            /// <summary>
            /// 流程编码 - 出国申请
            /// </summary>
            public const string CGoAbroadApply = "060";
            /// <summary>
            /// 流程编码 - 出国准备
            /// </summary>
            public const string CGoAbroadArranged = "061";
            /// <summary>
            /// 流程编码 - 保险申请
            /// </summary>
            public const string CInsuranceApply = "062";
            /// <summary>
            /// 流程编码 - 出国工作总结
            /// </summary>
            public const string CGoAbroadWorkSummary = "063";
            /// <summary>
            /// 流程编码 - 机票申请
            /// </summary>
            public const string CAirticketApply = "064";
            /// <summary>
            /// 流程编码 - 辞退
            /// </summary>
            public const string CWithOutADepartureApply = "065";
            /// <summary>
            /// 流程编码 - 出国申请商务事务出国
            /// </summary>
            public const string CGoAbroadBusiessApply = "066";
            /// <summary>
            /// 流程编码 - 出国申请（高管）
            /// </summary>
            public const string CGoAbroadManageApply = "067";
            /// <summary>
            /// 流程编码 - 转试用申请
            /// </summary>
            public const string CTurnToProbation = "068";
            /// <summary>
            /// 流程编码 - 中途录用
            /// </summary>
            public const string CMidwayEmploy = "069";
            /// <summary>
            /// 流程编码 - 职能部门调转
            /// </summary>
            public const string CFunctionalDep = "070";
            /// <summary>
            /// 流程编码 - 普通人员商务事务出国申请
            /// </summary>
            public const string CAppGoAbroadBusiess = "071";
            /// <summary>
            /// 流程编码 - 校园招聘计划
            /// </summary>
            public const string CSchoolRecruitPlan = "117";
            /// <summary>
            /// 流程编码 - 任职资格评委审批
            /// </summary>
            public const string CAppraisalMember = "077";
            /// <summary>
            /// 流程编码 - 任职资格申请（正常）
            /// </summary>
            public const string COrgSubmitStatusNormal = "079";
            /// <summary>
            /// 流程编码 - 任职资格申请（详细）
            /// </summary>
            public const string COrgSubmitStatusSepical = "080";
            /// <summary>
            /// 流程编码 - 任职资格延期申请
            /// </summary>
            public const string CQualificationDefer = "081";
            /// <summary>
            /// 流程编码 - 任职资格最终结果
            /// </summary>
            public const string CResultApprove = "078";
            /// <summary>
            /// 流程编码 - 外协调转申请
            /// </summary>
            public const string CVendorTransferApply = "085";


        }
        #endregion

        #region 帐套Code.
        /// <summary>
        /// 帐套Code.
        /// </summary>
        public class AccCode
        {
            /// <summary>
            /// 帐套Code - 大连华信账套
            /// </summary>
            public const string CDHC = "911000";
            /// <summary>
            /// 帐套Code - 天津华信软件有限公司
            /// </summary>
            public const string CTJHC = "921000";
            /// <summary>
            /// 帐套Code - 日本华信账套
            /// </summary>
            public const string CJHC = "922000";
            /// <summary>
            /// 帐套Code - 工程中心账套
            /// </summary>
            public const string CMEE = "920000";
            /// <summary>
            /// 帐套Code - 培训中心账套
            /// </summary>
            public const string CDHEE = "924000";
            /// <summary>
            ///  帐套Code - 华信教育账套
            /// </summary>
            public const string CDHES = "925000";
            /// <summary>
            /// 帐套Code - 诺尔账套
            /// </summary>
            public const string CNES = "926000";
            /// <summary>
            ///  帐套Code - 华鞍账套
            /// </summary>
            public const string CDHA = "923000";
            /// <summary>
            /// 帐套Code - 济南华信账套
            /// </summary>
            public const string CJNHC = "928000";
            /// <summary>
            /// 帐套Code - 华信软件园物业账套
            /// </summary>
            public const string CDHSP = "934000";
            /// <summary>
            /// 帐套Code - 昆山华信账套
            /// </summary>
            public const string CKSHC = "935000";
            /// <summary>
            /// 帐套Code - 沈阳华信教育账套
            /// </summary>
            public const string CSET = "933000";
            /// <summary>
            /// 帐套Code - 永道账套
            /// </summary>
            public const string CYOUNDER = "927000";
            /// <summary>
            /// 帐套Code - 中信网科账套
            /// </summary>
            public const string CCITIC = "930000";
            /// <summary>
            /// 帐套Code - 华药账套
            /// </summary>
            public const string CCMEC = "939000";
            /// <summary>
            /// 帐套Code - 华铁海兴账套
            /// </summary>
            public const string CHTHX = "938000";
            /// <summary>
            /// 帐套Code - 苏州华信账套
            /// </summary>
            public const string CSZHC = "937000";
            /// <summary>
            /// 帐套Code - 冲绳华信株式会社
            /// </summary>
            public const string COHC = "940000";

        }

        #endregion

        #region 系统角色ID.
        /// <summary>
        ///  系统角色ID.
        /// </summary>
        public class ExHR_RoleID
        {
            /// <summary>
            ///  绩效负责人.
            /// </summary>
            public const string CPerformancePrincipal = "PerformancePrincipal";
            /// <summary>
            ///  部门经理.
            /// </summary>
            public const string CDepartmentPrincipal = "DepartmentPrincipal";
            /// <summary>
            ///  部门副经理.
            /// </summary>                   
            public const string CDepartmentSecondPrincipal = "DepartmentSecondPrincipal";
            /// <summary>
            ///   事业部长.
            /// </summary>     
            public const string CBusinessMinister = "BusinessMinister";
            /// <summary>
            ///  事业部以上.
            /// </summary>                       
            public const string CBusinessMinisterHigher = "BusinessMinisterHigher";
            /// <summary>
            ///  普通员工.
            /// </summary>
            public const string CConmmonStaff = "ConmmonStaff";
            /// <summary>
            ///   异动部门负责人.
            /// </summary>
            public const string CRegulaPrincipal = "RegulaPrincipal";
            /// <summary>
            /// 事业部HR（入职用邮件发送）.
            /// </summary>
            public const string CGroupHR = "GroupHR";
            /// <summary>
            /// 信息安全管理员.
            /// </summary>
            public const string CPersonIBInformationAercurity = "PersonIBInformationAercurity";
            /// <summary>
            ///  员工卡管理专员.
            /// </summary>
            public const string CCardManager = "CardManager";
            /// <summary>
            /// 门禁管理专员.
            /// </summary>
            public const string CDoorAuthorManager = "DoorAuthorManager";
            /// <summary>
            /// 部门助理.
            /// </summary>
            public const string CDepartmentAssistance = "DepartmentAssistance";
            /// <summary>
            /// 外事专员.
            /// </summary>
            public const string COutSidePerson = "OutSidePerson";
            /// <summary>
            /// 信息安全员.
            /// </summary>
            public const string CInformationSafePerson = "InformationSafePerson";
            /// <summary>
            /// 软件工程师.
            /// </summary>
            public const string CSoftwareEngineer = "SoftwareEngineer";
            /// <summary>
            /// 助理软件工程师.
            /// </summary>
            public const string CAssistantSoftwareEngineer = "AssistantSoftwareEngineer";
            /// <summary>
            /// 邮箱管理专员.
            /// </summary>
            public const string CDepEmailManager = "DepEmailManager";
            /// <summary>
            /// 招聘经理.
            /// </summary>
            public const string CRecruitPrincipal = "RecruitPrincipal";
            /// <summary>
            /// 中途招聘专员.
            /// </summary>
            public const string CMidwayRecruit = "MidwayRecruit";
            /// <summary>
            ///  外协招聘专员.
            /// </summary>
            public const string CExternalRecruit = "ExternalRecruit";
            /// <summary>
            /// 校园招聘专员.
            /// </summary>
            public const string CSchoolRecruit = "SchoolRecruit";
            /// <summary>
            /// 合同管理专员.
            /// </summary>
            public const string CContractManager = "ContractManager";
            /// <summary>
            /// 人事信息维护专员（入职）.
            /// </summary>
            public const string CStaffInfoMaintenance = "StaffInfoMaintenance";
            /// <summary>
            /// 招聘组.
            /// </summary>
            public const string CRecruitManagerList = "RecruitManagerList";
            /// <summary>
            ///  设备管理专员.
            /// </summary>
            public const string COrgEquipServiceManager = "OrgEquipServiceManager";
            /// <summary>
            /// 公司级软件管理专员.
            /// </summary>
            public const string CComSWManager = "ComSWManager";
            /// <summary>
            /// 公司级网络管理专员.
            /// </summary>
            public const string CNetWorkManager = "NetWorkManager";
            /// <summary>
            /// 公司级邮件列表管理专员.
            /// </summary>
            public const string CAssisEmailListManager = "AssisEmailListManager";
            /// <summary>
            /// 公司级绩效管理专员.
            /// </summary>
            public const string CComPEManager = "ComPEManager";
            /// <summary>
            /// HR任职资格专员.
            /// </summary>
            public const string CQualificationMaintenance = "QualificationMaintenance";
            /// <summary>
            /// 总经理角色.
            /// </summary>
            public const string CGeneralManager = "GeneralManager";
            /// <summary>
            /// 设备管理员.
            /// </summary>
            public const string COrgEquipSManager = "OrgEquipSManager";
            /// <summary>
            /// 电话管理专员.
            /// </summary>
            public const string COfficePhoneManager = "OfficePhoneManager";

        }
        #endregion

        #region 消息ID.
        /// <summary>
        /// 消息ID.
        /// </summary>
        public class ExMessageID
        {
            /// <summary>
            /// 消息ID -保存成功！.
            /// </summary>
            public const string CNEHRI0001 = "NEHRI0001";
            /// <summary>
            /// 消息ID -更新成功！.
            /// </summary>
            public const string CNEHRI0002 = "NEHRI0002";
            /// <summary>
            /// 消息ID -删除成功！.
            /// </summary>
            public const string CNEHRI0003 = "NEHRI0003";
            /// <summary>
            /// 消息ID -操作成功！.
            /// </summary>
            public const string CNEHRI0004 = "NEHRI0004";
            /// <summary>
            /// 消息ID -处理成功！.
            /// </summary>
            public const string CNEHRI0005 = "NEHRI0005";
            /// <summary>
            /// 消息ID -正常结束！.
            /// </summary>
            public const string CNEHRI0006 = "NEHRI0006";
            /// <summary>
            /// 消息ID -正在执行，请稍候….
            /// </summary>
            public const string CNEHRI0007 = "NEHRI0007";
            /// <summary>
            /// 消息ID -接口数据取得成功！.
            /// </summary>
            public const string CNEHRI0008 = "NEHRI0008";
            /// <summary>
            /// 消息ID -申请已成功启动！.
            /// </summary>
            public const string CNEHRI0009 = "NEHRI0009";
            /// <summary>
            /// 消息ID -指定人员【{0}】录入不正确,请重新录入！.
            /// </summary>
            public const string CNEHRE0010 = "NEHRE0010";
            /// <summary>
            /// 消息ID -{0}不能为空！. 
            /// </summary>
            public const string CNEHRI0011 = "NEHRI0011";
            /// <summary>
            /// 消息ID -确定要删除吗？.
            /// </summary>
            public const string CNEHRQ0012 = "NEHRQ0012";
            /// <summary>
            /// 消息ID -请选择考核活动！.
            /// </summary>
            public const string CNEHRI0013 = "NEHRI0013";
            /// <summary>
            /// 消息ID -请选择上级人员！.
            /// </summary>
            public const string CNEHRI0014 = "NEHRI0014";
            /// <summary>
            /// 消息ID -权重要不可大于100%！.
            /// </summary>
            public const string CNEHRI0015 = "NEHRI0015";
            /// <summary>
            ///  消息ID -至少选择一条记录！.
            /// </summary>
            public const string CNEHRI0016 = "NEHRI0016";
            /// <summary>
            /// 消息ID -请选择对应模板！.
            /// </summary>
            public const string CNEHRI0017 = "NEHRI0017";
            /// <summary>
            /// 消息ID -确认通过！.
            /// </summary>
            public const string CNEHRI0018 = "NEHRI0018";
            /// <summary>
            ///  消息ID -审核通过！.
            /// </summary>
            public const string CNEHRI0019 = "NEHRI0019";
            /// <summary>
            /// 消息ID -驳回成功！.
            /// </summary>
            public const string CNEHRI0020 = "NEHRI0020";
            /// <summary>
            /// 消息ID -提交成功！.
            /// </summary>
            public const string CNEHRI0021 = "NEHRI0021";
            /// <summary>
            /// 消息ID -请选择要确认的内容！.
            /// </summary>
            public const string CNEHRI0022 = "NEHRI0022";
            /// <summary>
            /// 消息ID -请选择要驳回的内容！.
            /// </summary>
            public const string CNEHRI0023 = "NEHRI0023";
            /// <summary>
            /// 消息ID -你无权进行删除操作！.
            /// </summary>
            public const string CNEHRI0024 = "NEHRI0024";
            /// <summary>
            /// 消息ID -【{0}】指标已经存在！.
            /// </summary>
            public const string CNEHRI0025 = "NEHRI0025";
            /// <summary>
            /// 消息ID -考核指标权重总和必须等于{0}指标类别权重!.
            /// </summary>
            public const string CNEHRI0026 = "NEHRI0026";
            /// <summary>
            /// 消息ID -指标类别权重总和必须等于100%！.
            /// </summary>
            public const string CNEHRI0027 = "NEHRI0027";
            /// <summary>
            ///  消息ID -存在目标设定已启动的数据，确定要删除吗？.
            /// </summary>
            public const string CNEHRQ0028 = "NEHRQ0028";
            /// <summary>
            /// 消息ID -要复制的以往活动，不能选择当前活动！.
            /// </summary>
            public const string CNEHRI0029 = "NEHRI0029";
            /// <summary>
            ///  消息ID -【{0}】员工目标已设定，请确认后在录入！.
            /// </summary>
            public const string CNEHRI0030 = "NEHRI0030";
            /// <summary>
            /// 消息ID -当前活动关系已设定，确定要复制关系吗？.
            /// </summary>
            public const string CNEHRQ0031 = "NEHRQ0031";
            /// <summary>
            /// 消息ID -没有数据可以导出！.
            /// </summary>
            public const string CNEHRI0032 = "NEHRI0032";
            /// <summary>
            /// 消息ID -{0}合同已存在，不能进行初签操作！.
            /// </summary>
            public const string CNEHRI0033 = "NEHRI0033";
            /// <summary>
            /// 消息ID -{0}录入不正确！.
            /// </summary>
            public const string CNEHRI0034 = "NEHRI0034";
            /// <summary>
            /// 消息ID -模板不存在！.
            /// </summary>
            public const string CNEHRI0035 = "NEHRI0035";
            /// <summary>
            /// 消息ID -没有数据可以打印！.
            /// </summary>
            public const string CNEHRI0036 = "NEHRI0036";
            /// <summary>
            /// 消息ID -以下人员的目标关系没有设定，无法导入考核关系！\r\n{0}.
            /// </summary>
            public const string CNEHRI0037 = "NEHRI0037";
            /// <summary>
            /// 消息ID -是否发送邮件？.
            /// </summary>
            public const string CNEHRQ0038 = "NEHRQ0038";
            /// <summary>
            /// 消息ID -导入后原关系会被覆盖，只保留本次导入关系！确定要导入员工目标关系吗？.
            /// </summary>
            public const string CNEHRQ0039 = "NEHRQ0039";
            /// <summary>
            /// 消息ID -导入后原关系会被覆盖，只保留本次导入关系！确定要导入员工考核关系吗？.
            /// </summary>
            public const string CNEHRQ0040 = "NEHRQ0040";
            /// <summary>
            /// 消息ID -导入{0}件，成功:{1}件/失败:{2}件。详细请参照桌面文件{3}！.
            /// </summary>
            public const string CNEHRI0041 = "NEHRI0041";
            /// <summary>
            /// 消息ID -该邮箱已存在！.
            /// </summary>
            public const string CNEHRE0042 = "NEHRE0042";
            /// <summary>
            /// 消息ID -该员工不存在！.
            /// </summary>
            public const string CNEHRE0043 = "NEHRE0043";
            /// <summary>
            /// 消息ID -该员工的档案已存在！.
            /// </summary>
            public const string CNEHRE0044 = "NEHRE0044";
            /// <summary>
            /// 消息ID -该员工的档案不存在！.
            /// </summary>
            public const string CNEHRE0045 = "NEHRE0045";
            /// <summary>
            /// 消息ID -该员工没有业务档案！.
            /// </summary>
            public const string CNEHRE0046 = "NEHRE0046";
            /// <summary>
            /// 消息ID -该员工没有人事档案！.
            /// </summary>
            public const string CNEHRE0047 = "NEHRE0047";
            /// <summary>
            /// 消息ID -该员工的人事档案已被借出！.
            /// </summary>
            public const string CNEHRE0048 = "NEHRE0048";
            /// <summary>
            /// 消息ID -该员工的业务档案已被借出！.
            /// </summary>
            public const string CNEHRE0049 = "NEHRE0049";
            /// <summary>
            ///  消息ID -该员工的人事档案和业务档案均已被借出！.
            /// </summary>
            public const string CNEHRE0050 = "NEHRE0050";
            /// <summary>
            /// 消息ID -最长续借时间为15天！.
            /// </summary>
            public const string CNEHRI0051 = "NEHRI0051";
            /// <summary>
            /// 消息ID -该员工的户籍已存在！.
            /// </summary>
            public const string CNEHRE0052 = "NEHRE0052";
            /// <summary>
            /// 消息ID -该员工的户籍不存在！.
            /// </summary>
            public const string CNEHRE0053 = "NEHRE0053";
            /// <summary>
            /// 消息ID -该员工的户籍已被借出！.
            /// </summary>
            public const string CNEHRE0054 = "NEHRE0054";
            /// <summary>
            ///  消息ID -户口簿编号重复，请重新输入！.
            /// </summary>
            public const string CNEHRE0057 = "NEHRE0057";
            /// <summary>
            /// 消息ID -自评不能为空，请填写自评分数！.
            /// </summary>
            public const string CNEHRE0058 = "NEHRE0058";
            /// <summary>
            /// 消息ID -所有指标项必须设定目标,请填写目标！.
            /// </summary>
            public const string CNEHRE0059 = "NEHRE0059";
            /// <summary>
            ///  消息ID -请查询出一种考核活动，才可对该考核活动进行人员指标设定！.
            /// </summary>
            public const string CNEHRI0060 = "NEHRI0060";
            /// <summary>
            ///  消息ID -没有该考核活动需要设定的人员，不可进行人员指标设定！.
            /// </summary>
            public const string CNEHRE0061 = "NEHRE0061";
            /// <summary>
            ///  消息ID -指标权重的值不能为零！.
            /// </summary>
            public const string CNEHRE0062 = "NEHRE0062";
            /// <summary>
            /// 消息ID -指标权重的值不能大于100%！.
            /// </summary>
            public const string CNEHRE0063 = "NEHRE0063";
            /// <summary>
            /// 消息ID -是否离开此模板？.
            /// </summary>
            public const string CNEHRQ0064 = "NEHRQ0064";
            /// <summary>
            /// 消息ID -类别权重分配不正确！.
            /// </summary>
            public const string CNEHRE0065 = "NEHRE0065";
            /// <summary>
            /// 消息ID -指标权重分配不正确！.
            /// </summary>
            public const string CNEHRE0066 = "NEHRE0066";
            /// <summary>
            ///  消息ID -自我评价输入格式为：整数位数不超过两位，小数位数不超过两位！.
            /// </summary>
            public const string CNEHRI0067 = "NEHRI0067";
            /// <summary>
            /// 消息ID -自我评价输入应在0到5之间，请重新输入！.
            /// </summary>
            public const string CNEHRE0068 = "NEHRE0068";
            /// <summary>
            /// 消息ID -自我评价增减项输入格式为：整数位数不超过三位，小数位数不超过两位！.
            /// </summary>
            public const string CNEHRI0069 = "NEHRI0069";
            /// <summary>
            /// 消息ID -评价不能为空，请填写评价分数！.
            /// </summary>
            public const string CNEHRE0070 = "NEHRE0070";
            /// <summary>
            /// 消息ID -没有考核指标！.
            /// </summary>
            public const string CNEHRE0071 = "NEHRE0071";
            /// <summary>
            /// 消息ID -上级评价输入格式为：整数位数不超过两位，小数位数不超过两位！.
            /// </summary>
            public const string CNEHRI0072 = "NEHRI0072";
            /// <summary>
            ///  消息ID -评价输入应在0到5之间，请重新输入！.
            /// </summary>
            public const string CNEHRE0073 = "NEHRE0073";
            /// <summary>
            /// 消息ID -上级评价增减项输入格式为：整数位数不超过三位，小数位数不超过两位！.
            /// </summary>
            public const string CNEHRI0074 = "NEHRI0074";
            /// <summary>
            /// 消息ID -没有满足条件的数据！.
            /// </summary>
            public const string CNEHRE0075 = "NEHRE0075";
            /// <summary>
            /// 消息ID -请查询出一种考核活动，才可查看考核等级分布状况！.
            /// </summary>
            public const string CNEHRI0076 = "NEHRI0076";
            /// <summary>
            /// 消息ID -考核期间与考核年度不相符！.
            /// </summary>
            public const string CNEHRE0077 = "NEHRE0077";
            /// <summary>
            /// 消息ID -您要借用的户籍在库数为0！.
            /// </summary>
            public const string CNEHRI0078 = "NEHRI0078";
            /// <summary>
            /// 消息ID -该员工的户籍已迁出！.
            /// </summary>
            public const string CNEHRE0079 = "NEHRE0079";
            /// <summary>
            ///  消息ID -最长借用期间为15天！.
            /// </summary>
            public const string CNEHRI0080 = "NEHRI0080";
            /// <summary>
            /// 消息ID -使用的导入模板不正确，请使用导出的模板进行导入！.
            /// </summary>
            public const string CNEHRI0081 = "NEHRI0081";
            /// <summary>
            /// 消息ID -请输入有效的员工编号！.
            /// </summary>
            public const string CNEHRI0082 = "NEHRI0082";
            /// <summary>
            ///  消息ID -请输入有效日期！.
            /// </summary>
            public const string CNEHRI0083 = "NEHRI0083";
            /// <summary>
            ///  消息ID -确定要修改开始日期么..？.
            /// </summary>
            public const string CNEHRQ0084 = "NEHRQ0084";
            /// <summary>
            /// 消息ID -该员工编号不存在...
            /// </summary>
            public const string CNEHRI0085 = "NEHRI0085";
            /// <summary>
            /// 消息ID -确定要导入人员组织关系么？.
            /// </summary>
            public const string CNEHRQ0086 = "NEHRQ0086";
            /// <summary>
            ///  消息ID -请选择有效人员...！.
            /// </summary>
            public const string CNEHRI0087 = "NEHRI0087";
            /// <summary>
            /// 消息ID -确定导入人员特殊岗位履历吗？.
            /// </summary>
            public const string CNEHRQ0088 = "NEHRQ0088";
            /// <summary>
            /// 消息ID -确定要取消出国吗？.
            /// </summary>
            public const string CNEHRQ0089 = "NEHRQ0089";
            /// <summary>
            ///  消息ID -该院校已存在！.
            /// </summary>
            public const string CNEHRE0090 = "NEHRE0090";
            /// <summary>
            ///  消息ID -请选择被推荐人中有效的人员信息！.
            /// </summary>
            public const string CNEHRI0091 = "NEHRI0091";
            /// <summary>
            /// 消息ID -是否继续【{0}】操作?.
            /// </summary>
            public const string CNEHRQ0092 = "NEHRQ0092";
            /// <summary>
            /// 消息ID -请先预定机票！.
            /// </summary>
            public const string CNEHRI0093 = "NEHRI0093";
            /// <summary>
            /// 消息ID -请选择组织！.
            /// </summary>
            public const string CNEHRI0094 = "NEHRI0094";
            /// <summary>
            ///  消息ID -邮箱生效时间为过去时间，无法修改！.
            /// </summary>
            public const string CNEHRI0095 = "NEHRI0095";
            /// <summary>
            ///  消息ID -考核活动已经结束，无法进行操作！.
            /// </summary>
            public const string CNEHRI0096 = "NEHRI0096";
            /// <summary>
            ///  消息ID -请添加外协人员！.
            /// </summary>
            public const string CNEHRI0097 = "NEHRI0097";
            /// <summary>
            /// 消息ID -没有数据修改！.
            /// </summary>
            public const string CNEHRI0098 = "NEHRI0098";
            /// <summary>
            /// 消息ID -最多只能选择一条数据！.
            /// </summary>
            public const string CNEHRI0099 = "NEHRI0099";
            /// <summary>
            /// 消息ID -您确定要导入奖惩信息吗？.
            /// </summary>
            public const string CNEHRQ0100 = "NEHRQ0100";
            /// <summary>
            /// 消息ID -该年度已存在！.
            /// </summary>
            public const string CNEHRI0101 = "NEHRI0101";
            /// <summary>
            ///  消息ID -年度长度不正确！.
            /// </summary>
            public const string CNEHRI0102 = "NEHRI0102";
            /// <summary>
            /// 消息ID -年度应该为数字！.
            /// </summary>
            public const string CNEHRI0103 = "NEHRI0103";
            /// <summary>
            /// 消息ID -流失率应该为数字！.
            /// </summary>
            public const string CNEHRI0104 = "NEHRI0104";
            /// <summary>
            /// 消息ID -工资应该为数字！.
            /// </summary>
            public const string CNEHRI0105 = "NEHRI0105";
            /// <summary>
            /// 消息ID -确定要结束校园招聘计划【{0}】吗？.
            /// </summary>
            public const string CNEHRQ0106 = "NEHRQ0106";
            /// <summary>
            /// 消息ID -确定要导入职位基本信息吗？.
            /// </summary>
            public const string CNEHRQ0107 = "NEHRQ0107";
            /// <summary>
            ///  消息ID -确定要导入职务基本信息吗？.
            /// </summary>
            public const string CNEHRQ0108 = "NEHRQ0108";
            /// <summary>
            /// 消息ID -确定要导入特殊岗位基本信息吗？.
            /// </summary>
            public const string CNEHRQ0109 = "NEHRQ0109";
            /// <summary>
            /// 消息ID -确定要导入员工职位信息吗？.
            /// </summary>
            public const string CNEHRQ0110 = "NEHRQ0110";
            /// <summary>
            /// 消息ID -确定要导入员工职务信息吗？.
            /// </summary>
            public const string CNEHRQ0111 = "NEHRQ0111";
            /// <summary>
            /// 消息ID -确定要导入员工任职资格吗？.
            /// </summary>
            public const string CNEHRQ0112 = "NEHRQ0112";
            /// <summary>
            /// 消息ID -该条需求您已经自荐过了！.
            /// </summary>
            public const string CNEHRI0113 = "NEHRI0113";
            /// <summary>
            ///  消息ID -预订日期小于当前日期，请重新确定！.
            /// </summary>
            public const string CNEHRI0114 = "NEHRI0114";
            /// <summary>
            /// 消息ID -出国申请必须在出国前的10个工作日之前提请，您当前的申请不足10个工作日，不能提交申请！.
            /// </summary>
            public const string CNEHRI0115 = "NEHRI0115";
            /// <summary>
            ///  消息ID -确定要结束此校园招聘计划吗？.
            /// </summary>
            public const string CNEHRQ0116 = "NEHRQ0116";
            /// <summary>
            ///  消息ID -推荐人说明已超出最大长度200！.
            /// </summary>
            public const string CNEHRI0117 = "NEHRI0117";
            /// <summary>
            /// 消息ID -简历文件不可为空！.
            /// </summary>
            public const string CNEHRI0118 = "NEHRI0118";
            /// <summary>
            /// 消息ID -合作开始日不能大于合作结束日！.
            /// </summary>
            public const string CNEHRI0119 = "NEHRI0119";
            /// <summary>
            ///   消息ID -请输入0到100间的分值！.
            /// </summary>
            public const string CNEHRI0120 = "NEHRI0120";
            /// <summary>
            /// 消息ID -评价分数只能为数字！.
            /// </summary>
            public const string CNEHRI0121 = "NEHRI0121";
            /// <summary>
            /// 消息ID -作业开始日不能大于作业结束日，请重新输入！.
            /// </summary>
            public const string CNEHRI0122 = "NEHRI0122";
            /// <summary>
            ///  消息ID -不能重复添加同一人员，请重新选择！.
            /// </summary>
            public const string CNEHRI0123 = "NEHRI0123";
            /// <summary>
            /// 消息ID -员工未确认，员工确认之后才可确认通过！.
            /// </summary>
            public const string CNEHRI0124 = "NEHRI0124";
            /// <summary>
            /// 消息ID -【{0}】特殊岗位已存在，不能重复追加！.
            /// </summary>
            public const string CNEHRI0125 = "NEHRI0125";
            /// <summary>
            /// 消息ID -【{0}】职位已存在，不能重复追加！.
            /// </summary>
            public const string CNEHRI0126 = "NEHRI0126";
            /// <summary>
            ///  消息ID -【{0}】职务已存在，不能重复追加！.
            /// </summary>
            public const string CNEHRI0127 = "NEHRI0127";
            /// <summary>
            /// 消息ID - 招聘流失率整数位数不超过三位，小数位数不超过两位！.
            /// </summary>
            public const string CNEHRI0128 = "NEHRI0128";
            /// <summary>
            /// 消息ID - 请先进行{0}评价，在做申请操作！.
            /// </summary>
            public const string CNEHRI0129 = "NEHRI0129";
            /// <summary>
            /// 消息ID -【{0}】员工任职信息已存在，不能重复追加！.
            /// </summary>
            public const string CNEHRI0130 = "NEHRI0130";
            /// <summary>
            /// 消息ID -【{0}】员工任职有效期间与前一任职有效期间冲突，请确认！！.
            /// </summary>
            public const string CNEHRI0131 = "NEHRI0131";
            /// <summary>
            ///  消息ID -【{0}】员工任命信息已存在，不能重复追加！.
            /// </summary>
            public const string CNEHRI0132 = "NEHRI0132";
            /// <summary>
            /// 消息ID -【{0}】员工任命有效期间与前一任命有效期间冲突，请确认！.
            /// </summary>
            public const string CNEHRI0133 = "NEHRI0133";
            /// <summary>
            /// 消息ID -【{0}】员工任职信息已失效，不能修改！.
            /// </summary>
            public const string CNEHRI0134 = "NEHRI0134";
            /// <summary>
            /// 消息ID -【{0}】员工任命信息已失效，不能修改！.
            /// </summary>
            public const string CNEHRI0135 = "NEHRI0135";
            /// <summary>
            ///  消息ID -【{0}】员工存在当前有效的主职，请确认！.
            /// </summary>
            public const string CNEHRI0136 = "NEHRI0136";
            /// <summary>
            /// 消息ID - 至少选择一条校园招聘详细信息！.
            /// </summary>
            public const string CNEHRI0137 = "NEHRI0137";
            /// <summary>
            /// 消息ID - 身份证编号{0}格式录入不正确！.
            /// </summary>
            public const string CNEHRI0138 = "NEHRI0138";
            /// <summary>
            /// 消息ID - 您录入的出生日期{0}和录入的身份证编号{1}的出生日期不一致，是否要修改出生日期？.
            /// </summary>
            public const string CNEHRQ0139 = "NEHRQ0139";
            /// <summary>
            /// 消息ID - 只能同时调出同级别的员工，如果员工级别不同，请分开调动！.
            /// </summary>
            public const string CNEHRI0140 = "NEHRI0140";
            /// <summary>
            ///  消息ID -  确定要取消入职吗？.
            /// </summary>
            public const string CNEHRQ0141 = "NEHRQ0141";
            /// <summary>
            ///  消息ID -  确定要处理此次续签合同吗？.
            /// </summary>
            public const string CNEHRQ0142 = "NEHRQ0142";
            /// <summary>
            /// 消息ID -  确定同意续签吗？.
            /// </summary>
            public const string CNEHRQ0143 = "NEHRQ0143";
            /// <summary>
            ///  消息ID -  确定拒绝续签吗？.
            /// </summary>
            public const string CNEHRQ0144 = "NEHRQ0144";
            /// <summary>
            ///  消息ID -  确定归还吗？.
            /// </summary>
            public const string CNEHRQ0145 = "NEHRQ0145";
            /// <summary>
            /// 消息ID -  报表生成时发生异常！.
            /// </summary>
            public const string CNEHRI0146 = "NEHRI0146";
            /// <summary>
            /// 消息ID -  确定只保存不提交申请吗？.
            /// </summary>
            public const string CNEHRQ0147 = "NEHRQ0147";
            /// <summary>
            ///  消息ID -  员工编号已生成，不能再次生成！.
            /// </summary>
            public const string CNEHRI0148 = "NEHRI0148";
            /// <summary>
            /// 消息ID -  请选择员工类型之后在生成卡号！.
            /// </summary>
            public const string CNEHRI0149 = "NEHRI0149";
            /// <summary>
            /// 消息ID -  请生成员工卡号！.
            /// </summary>
            public const string CNEHRI0150 = "NEHRI0150";
            /// <summary>
            /// 消息ID -  确定要投保吗？.
            /// </summary>
            public const string CNEHRQ0151 = "NEHRQ0151";
            /// <summary>
            /// 消息ID -  确定要申请签证吗？.
            /// </summary>
            public const string CNEHRQ0152 = "NEHRQ0152";
            /// <summary>
            /// 消息ID -  确定要保留签证吗？.
            /// </summary>
            public const string CNEHRQ0153 = "NEHRQ0153";
            /// <summary>
            /// 消息ID -  确定要预定机票吗？.
            /// </summary>
            public const string CNEHRQ0154 = "NEHRQ0154";
            /// <summary>
            /// 消息ID -  确定要出票吗？.
            /// </summary>
            public const string CNEHRQ0155 = "NEHRQ0155";
            /// <summary>
            /// 消息ID -  相关申请审批未结束，不能进行此申请！.
            /// </summary>
            public const string CNEHRI0156 = "NEHRI0156";
            /// <summary>
            /// 消息ID -  确定要调出档案吗？.
            /// </summary>
            public const string CNEHRQ0157 = "NEHRQ0157";
            /// <summary>
            /// 消息ID -  邮箱正在生成中，不能导出数据！.
            /// </summary>
            public const string CNEHRI0158 = "NEHRI0158";
            /// <summary>
            /// 消息ID -  请添加用票人信息！.
            /// </summary>
            public const string CNEHRI0159 = "NEHRI0159";
            /// <summary>
            /// 消息ID -  只能选择一条招聘需求信息！.
            /// </summary>
            public const string CNEHRI0160 = "NEHRI0160";
            /// <summary>
            /// 消息ID -  自荐人员不能导入人才库！.
            /// </summary>
            public const string CNEHRI0161 = "NEHRI0161";
            /// <summary>
            /// 消息ID -  离职交接工作流还没有启动，暂时不能查看流程状态！.
            /// </summary>
            public const string CNEHRI0162 = "NEHRI0162";
            /// <summary>
            /// 消息ID -  请选择相同的需求职位!.
            /// </summary>
            public const string CNEHRI0163 = "NEHRI0163";
            /// <summary>
            /// 消息ID -  选择的数据中包含自荐的数据，确定要受理吗？.
            /// </summary>
            public const string CNEHRQ0164 = "NEHRQ0164";
            /// <summary>
            /// 消息ID -  您录入的出生日期{0}和身份证编号{1}的出生日期不一致，请重新录入！.
            /// </summary>
            public const string CNEHRI0165 = "NEHRI0165";
            /// <summary>
            /// 消息ID -  广告开始日期应该小于广告结束日期！.
            /// </summary>
            public const string CNEHRI0166 = "NEHRI0166";
            /// <summary>
            ///  消息ID -  确定要修改目标吗？.
            /// </summary>
            public const string CNEHRQ0167 = "NEHRQ0167";
            /// <summary>
            ///  消息ID -  确定受理吗？.
            /// </summary>
            public const string CNEHRQ0168 = "NEHRQ0168";
            /// <summary>
            /// 消息ID -  确定拒绝吗？.
            /// </summary>
            public const string CNEHRQ0169 = "NEHRQ0169";
            /// <summary>
            /// 消息ID -  确定要导入组织信息吗？.
            /// </summary>
            public const string CNEHRQ0170 = "NEHRQ0170";
            /// <summary>
            ///  消息ID -  确定要导入成本中心信息吗？.
            /// </summary>
            public const string CNEHRQ0171 = "NEHRQ0171";
            /// <summary>
            /// 消息ID -  变更生效日应大于开始日！.
            /// </summary>
            public const string CNEHRI0172 = "NEHRI0172";
            /// <summary>
            /// 消息ID -  输入的变更生效日不能小于上一条数据的变更开始日！.
            /// </summary>
            public const string CNEHRI0173 = "NEHRI0173";
            /// <summary>
            /// 消息ID -  请选择技术！.
            /// </summary>
            public const string CNEHRI0174 = "NEHRI0174";
            /// <summary>
            /// 消息ID -  导入{0}件，成功:{1}件/失败:{2}件。请下载导入结果文件查看错误数据！.
            /// </summary>
            public const string CNEHRI0175 = "NEHRI0175";
            /// <summary>
            /// 消息ID -  导入{0}件，成功:{1}件/失败:{2}件。.
            /// </summary>
            public const string CNEHRI0176 = "NEHRI0176";
            /// <summary>
            /// 消息ID -  员工自荐的数据不能执行导入人才库操作！.
            /// </summary>
            public const string CNEHRI0177 = "NEHRI0177";
            /// <summary>
            ///  消息ID -  内部推荐的人才未导入人才库之前不能受理！.
            /// </summary>
            public const string CNEHRI0178 = "NEHRI0178";
            /// <summary>
            /// 消息ID -  请选择一条数据！.
            /// </summary>
            public const string CNEHRI0179 = "NEHRI0179";
            /// <summary>
            /// 消息ID -  {0}不能大于{1}！.
            /// </summary>
            public const string CNEHRI0180 = "NEHRI0180";
            /// <summary>
            ///  消息ID -  {0}不能小于{1}！.
            /// </summary>
            public const string CNEHRI0181 = "NEHRI0181";
        }
        #endregion

        #region Mail类型UID.
        /// <summary>
        /// Mail类型UID.
        /// </summary>
        public class ExMessageKind
        {
            /// <summary>
            /// 向部门经理发送合同到期提醒邮件模板UID
            /// </summary>
            public const string CERtoPMUID = "3ae7e88b-c95e-4f07-b5f4-f0149f00e000";
            /// <summary>
            /// 向合同管理专员发送合同到期提醒邮件模板UID
            /// </summary>
            public const string CERtoCMSUID = "3ae7e88b-c95e-4f07-b5f4-f0149f00e111";
            /// <summary>
            ///  向员工本人发送合同到期提醒邮件模板UID
            /// </summary>
            public const string CERtoStaffUID = "3ae7e88b-c95e-4f07-b5f4-f0149f00e222";
            /// <summary>
            /// 面试安排面试官Mail模板UID
            /// </summary>
            public const string CArrangeInterviewerMailUID = "10000000-0000-0000-0000-000000000050";
            /// <summary>
            /// 面试取消候选人Mail模板UID
            /// </summary>
            public const string CAbolishCandidateMailUID = "10000000-0000-0000-0000-000000000051";
            /// <summary>
            /// 面试安排候选人Mail模板UID
            /// </summary>
            public const string CArrangeCandidateMailUID = "10000000-0000-0000-0000-000000000052";
            /// <summary>
            /// 面试取消面试官或需求提出者Mail模板UID
            /// </summary>
            public const string CAbolishInterviewerMailUID = "10000000-0000-0000-0000-000000000053";
            /// <summary>
            /// 面试结果通知Mail模板UID
            /// </summary>
            public const string CInterviewResultMailUID = "10000000-0000-0000-0000-000000000054";
            /// <summary>
            /// 面试官面试通知Mail模板UID
            /// </summary>
            public const string CInterviewerNotifyMailUID = "10000000-0000-0000-0000-000000000055";
            /// <summary>
            /// 人才筛选结果通知Mail模板UID
            /// </summary>
            public const string CFiltrationResultMailUID = "10000000-0000-0000-0000-000000000056";
            /// <summary>
            /// 人才推荐通知Mail模板UID
            /// </summary>
            public const string CTalentRecommend = "10000000-0000-0000-0000-000000000057";
            /// <summary>
            /// 删除面试官通知Mail模板UID
            /// </summary>
            public const string CCancelInterviewer = "10000000-0000-0000-0000-000000000058";
            /// <summary>
            /// 部门人员入职通知
            /// </summary>
            public const string CPersonIBOrgMessageID = "10000000-0000-0000-0000-000000000059";
            /// <summary>
            /// 人员分配通知单
            /// </summary>
            public const string CPersonIBPractMessageID = "10000000-0000-0000-0000-000000000060";
            /// <summary>
            /// 新入职员工提醒
            /// </summary>
            public const string CPersonIBInformationAercurityID = "10000000-0000-0000-0000-000000000061";
            /// <summary>
            /// 绩效考核活动启动
            /// </summary>
            public const string CPESubjectStartUID = "10000000-0000-0000-0000-000000000071";
            /// <summary>
            /// 绩效考核结果确认
            /// </summary>
            public const string CPEExamineAppraiseResultUID = "10000000-0000-0000-0000-000000000070";
            /// <summary>
            /// 绩效考核目标确认
            /// </summary>
            public const string CPEExamineTargetResultUID = "10000000-0000-0000-0000-000000000069";
            /// <summary>
            /// 绩效考核目标设定
            /// </summary>
            public const string CPEExamineTargetResultPCMMUID = "CFD598AC-344D-4E50-A507-5A0C4BE6E853";
            /// <summary>
            /// 绩效考核目标审核驳回
            /// </summary>
            public const string CChangedConfirmBackUID = "E3D7DCC4-6A8E-4E1C-BFE0-1DED03CB92E4";
            /// <summary>
            /// 绩效考核目标驳回
            /// </summary>
            public const string CGoalConfirmBackUID = "B3EF00F2-152D-4224-A673-1E5DC02FF329";
            /// <summary>
            /// 调动通知
            /// </summary>
            public const string CPersonManoeuvreMessageUID = "10000000-0000-0000-0000-000000000062";
            /// <summary>
            /// 跨公司调动通知
            /// </summary>
            public const string CPersonCompanyManoeuvreMessageUID = "10000000-0000-0000-0000-000000000063";
            /// <summary>
            /// 职能部门人员入职通知
            /// </summary>
            public const string CPersonFunctionInformationAercurityID = "10000000-0000-0000-0000-000000000064";
            /// <summary>
            /// 试用期/实习期/见习期考核目标确认
            /// </summary>
            public const string CPersonExamineTargetResultUID = "10000000-0000-0000-0000-000000000065";
            /// <summary>
            /// 试用期/实习期/见习期考核结果确认
            /// </summary>
            public const string CPersonAppraiseResultUID = "10000000-0000-0000-0000-000000000066";
            /// <summary>
            /// 员工卡办理通知
            /// </summary>
            public const string CPersonCardMessageUID = "10000000-0000-0000-0000-000000000067";
            /// <summary>
            /// 关于停止擅自离职人员在公司权限的通知
            /// </summary>
            public const string CPersonLeaveOfficeAuthorityUID = "10000000-0000-0000-0000-000000000068";
            /// <summary>
            /// 出国天数提醒
            /// </summary>
            public const string CExitDayMessageUID = "10000000-0000-0000-0000-000000000073";
            /// <summary>
            /// 出国次数提醒
            /// </summary>
            public const string CExitCountMessageUID = "10000000-0000-0000-0000-000000000074";
            /// <summary>
            /// 信息安全培训通知
            /// </summary>
            public const string CInformationSafeTradeUID = "10000000-0000-0000-0000-000000000075";
            /// <summary>
            /// 出国相关申请审批通过通知
            /// </summary>
            public const string CExitMessageUID = "10000000-0000-0000-0000-000000000076";
            /// <summary>
            /// 中途人才录用
            /// </summary>
            public const string CMidwayEmployMessageUID = "10000000-0000-0000-0000-000000000083";
            /// <summary>
            /// 外协人才录用
            /// </summary>
            public const string CVendorEmployMessageUID = "10000000-0000-0000-0000-000000000084";
            /// <summary>
            /// 调动人员邮箱跟踪提醒
            /// </summary>
            public const string CRemindEmialAddressMessageUID = "10000000-0000-0000-0000-000000000085";
            /// <summary>
            /// 户籍借用领取通知
            /// </summary>
            public const string CLineUpBCRMessageUID = "10000000-0000-0000-0000-000000000086";
            /// <summary>
            /// 需求提出通知
            /// </summary>
            public const string CRequestTiChuMessageUID = "10000000-0000-0000-0000-000000000087";
            /// <summary>
            /// 员工信息确认通知
            /// </summary>
            public const string CStaffInfoConfirmMessageUID = "10000000-0000-0000-0000-000000000095";
            /// <summary>
            /// 员工离职提醒部门经理和GroupHR剩余年休等情况
            /// </summary>
            public const string CLeaveOfficMessageUID = "10000000-0000-0000-0000-000000000096";
            /// <summary>
            /// 员工离职提醒信息安全
            /// </summary>
            public const string CLeaveOfficInforSafeMessageUID = "10000000-0000-0000-0000-000000000097";

            public const string CRenewalInsuranceMessageUID = "10000000-0000-0000-0000-000000000099";
            /// <summary>
            /// 员工内部推荐通知
            /// </summary>
            public const string CRecommendOneselfMessageUID = "10000000-0000-0000-0000-000000000100";
            /// <summary>
            /// 员工内部推荐通知
            /// </summary>
            public const string CRecommendStaffMessageUID = "10000000-0000-0000-0000-000000000101";
            /// <summary>
            /// 特殊岗位变更通知
            /// </summary>
            public const string CStaffPositionMessageUID = "10000000-0000-0000-0000-000000000102";
            /// <summary>
            /// 特殊岗位变更通知
            /// </summary>
            public const string CVendorStaffEvaluateMessageUID = "10000000-0000-0000-0000-000000000103";
            /// <summary>
            /// 综合评审提醒
            /// </summary>
            public const string CRemindAppraisalResultUID = "10000000-0000-0000-0000-000000000104";
            /// <summary>
            /// 评委提醒(删除）
            /// </summary>
            public const string CDelAppraisalResultUID = "10000000-0000-0000-0000-000000000105";
            /// <summary>
            /// 评委提醒
            /// </summary>
            public const string CNewAppraisalResultUID = "10000000-0000-0000-0000-000000000107";
            /// <summary>
            /// 员工撤销本次任职资格申请
            /// </summary>
            public const string CStaffQualificationCancelUID = "10000000-0000-0000-0000-000000000108";
            /// <summary>
            /// 员工任职资格取消通知
            /// </summary>
            public const string CStaffQualificationCancelForQUID = "10000000-0000-0000-0000-000000000109";
            /// <summary>
            /// 员工任职资格申报通知
            /// </summary>
            public const string CStaffQualificationApplyForQUID = "10000000-0000-0000-0000-000000000116";
            /// <summary>
            /// 任职资格最终结果通知(成功)
            /// </summary>
            public const string CResultApproveForSuccess = "10000000-0000-0000-0000-000000000117";
            /// <summary>
            /// 任职资格最终结果通知(失败)
            /// </summary>
            public const string CResultApproveForFailed = "10000000-0000-0000-0000-000000000118";
            /// <summary>
            /// 任职资格结果发布通知
            /// </summary>
            public const string CQualificationResultPublishUID = "10000000-0000-0000-0000-000000000119";
            /// <summary>
            /// WebHR出国投保提醒(成功投保)
            /// </summary>
            public const string CRecommendInsuranceStateUID = "10000000-0000-0000-0000-000000000120";
            /// <summary>
            /// WebHR员工合同续签意向通知
            /// </summary>
            public const string CRecommendPersonWill = "10000000-0000-0000-0000-000000000121";
            /// <summary>
            /// WebHR人员录用提醒
            /// </summary>
            public const string CEmployMailUID = "10000000-0000-0000-0000-000000000122";
            /// <summary>
            /// 员工绩效考核结果拒绝通知
            /// </summary>
            public const string CPERefuseUID = "10000000-0000-0000-0000-000000000123";
            /// <summary>
            /// 外协人员评价委托通知
            /// </summary>
            public const string CVendorEvaluateEntrustUID = "10000000-0000-0000-0000-000000000125";
            /// <summary>
            /// 外协人员评价通知
            /// </summary>
            public const string CVendorEvaluateMessageUID = "10000000-0000-0000-0000-000000000126";
            /// <summary>
            /// 调动提醒（设备管理员）
            /// </summary>
            public const string CTransferReserveMessageUID = "7AB82874-3CE5-4401-AA08-1A0D86C5226A";
            /// <summary>
            /// 出国申请员工的续签合同通知
            /// </summary>
            public const string CGoAbroadContinueSignMessageUID = "58727C63-5729-4F36-84C2-5594E00993D7";
            /// <summary>
            /// 员工任职资格申请被驳回通知
            /// </summary>
            public const string CRefuseQualificationApplyMessageUID = "FCFC9981-5ED4-49E8-8F85-4AE04E1CD19A";
            /// <summary>
            /// 员工异动申请是终止雇佣的通知
            /// </summary>
            public const string CRegularIsStopEmployMessageUID = "4A4A66B5-9A94-41E7-86AA-EC5F5CF76B51";
            /// <summary>
            /// 给闲置人才发送招聘职位的邮件提醒
            /// </summary>
            public const string CMailToTalentMessageUID = "43f4eab1-20c9-4fb5-ace7-823168bfe7cf";

            /// <summary>
            /// 给闲置人才发送招聘职位的邮件提醒
            /// </summary>
            public const string CRequireRecommendMessageUID = "10000000-0000-0000-0000-000000000130";


        }
        #endregion

        #region 集团内部各公司UID.
        /// <summary>
        /// 集团内部各公司UID.
        /// </summary>
        /// <remarks></remarks>
        public class ComputerCorporation
        {
            /// <summary>
            /// 华信计算机日本有限公司
            /// </summary>
            public const string CJHCComputer = "00000000-0000-0000-0000-000000000070";
        }
        #endregion

        #region 用户权限组UID.
        /// <summary>
        /// 用户权限组UID.
        /// </summary>
        public class ExRole
        {
            /// <summary>
            /// 目标设定人	进行组织的绩效关系设定
            /// </summary>
            public const string CPEGoalConfirmAuthor = "00000000-0000-0000-0006-000000000508";
            /// <summary>
            /// 目标审核人	进行组织的绩效关系设定
            /// </summary>
            public const string CPEGoalAuditAuthor = "00000000-0000-0000-0006-000000000509";
            /// <summary>
            /// 评价人	进行组织的绩效关系设定
            /// </summary>
            public const string CPEEvaluateAuthor = "00000000-0000-0000-0006-000000000510";
            /// <summary>
            /// 评价审核人	进行组织的绩效关系设定
            /// </summary>
            public const string CPEApproveAuthor = "00000000-0000-0000-0006-000000000511";
            /// <summary>
            /// 目标设定人 实习期考核权限
            /// </summary>
            public const string CPracticeAuthor = "00000000-0000-0000-0006-000000000303";
            /// <summary>
            /// 目标设定人 试用期考核权限
            /// </summary>
            public const string CProbationAuthor = "00000000-0000-0000-0006-000000000305";
            /// <summary>
            /// 大连华信计算机技术股份有限公司账套
            /// </summary>
            public const string AccDHC = "00000000-0000-0000-0000-000000000001";

            public const string CRCInterviewStaff = "00000000-0000-0000-0006-000000000206";
            /// <summary>
            /// 高管执行（登陆时画面链接到总裁桌面）
            /// </summary>
            public const string CHigherManager = "b3028eef-4c98-479b-923f-5313a91583d2";
            /// <summary>
            /// 高管辅助（登陆时画面链接到总裁桌面）
            /// </summary>
            public const string CHigherManagerAssist = "380dfd80-3914-4bd8-9110-7a4aaab6c561";
            /// <summary>
            /// 事业部级任职资格专员
            /// </summary>
            public const string CHr = "00000000-0000-0000-0006-000000000413";
            /// <summary>
            /// 公司任职资格专员
            /// </summary>
            public const string CQualification = "00000000-0000-0000-0006-000000000412";
            /// <summary>
            /// 任职资格部门经理跟踪权限
            /// </summary>
            public const string CDepartmentManager = "00000000-0000-0000-0006-000000000415";
            /// <summary>
            /// 面试候选人\待入职等没有办理入职手续的人员
            /// </summary>
            public const string CCandidate = "00000000-0000-0000-0006-000000000002";
        }
        #endregion


    }
}