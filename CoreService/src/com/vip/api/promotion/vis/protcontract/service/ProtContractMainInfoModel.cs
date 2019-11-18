using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractMainInfoModel {
		
		///<summary>
		/// 主键
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 确认函编号
		///</summary>
		
		private string protNo_;
		
		///<summary>
		/// 签署公司,0:未知，1:唯品会（中国）有限公司及其子公司（珠海子公司，重庆子公司），2：广州唯品会信息科技有限公司 , 3 : 乐蜂（上海）信息技术有限公司，4：Vipshop International Holdings Limited，5：广州好信医药连锁有限公司，6：广州唯品会电子商务有限公司
		///</summary>
		
		private int? companyId_;
		
		///<summary>
		/// 合同编码
		///</summary>
		
		private string contractNo_;
		
		///<summary>
		/// 合同名称
		///</summary>
		
		private string contractName_;
		
		///<summary>
		/// 合同时间
		///</summary>
		
		private long? contractTime_;
		
		///<summary>
		/// 签约模式 （1： 普通模式， 2：电子印章，3：验证码模式）
		///</summary>
		
		private byte? signMode_;
		
		///<summary>
		/// 供应商code
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 专场名称
		///</summary>
		
		private string specialName_;
		
		///<summary>
		/// 活动范围（4:特卖会（含PC + APP + WAP + 唯品会旗舰店（京东）+ 微Q端（京东））,5:其他（花海仓、乐蜂等APP））
		///</summary>
		
		private byte? rangeType_;
		
		///<summary>
		/// 活动类型,1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动
		///</summary>
		
		private string activityAlltype_;
		
		///<summary>
		/// 上线时间
		///</summary>
		
		private long? onlineStarttime_;
		
		///<summary>
		/// 下线时间
		///</summary>
		
		private long? onlineEndtime_;
		
		///<summary>
		/// 基本状态。0：未到阶段,1:已提交
		///</summary>
		
		private byte? basicStatus_;
		
		///<summary>
		/// 审批状态。0：未到阶段,1:已通过，2：已驳回,3:待处理
		///</summary>
		
		private byte? assistantStatus_;
		
		///<summary>
		/// 经理审批状态。0：未到阶段,1:已通过，2：已驳回,3:待处理
		///</summary>
		
		private byte? managerStatus_;
		
		///<summary>
		/// 总监审批状态。0：未到阶段,1:已通过，2：已驳回,3:待处理
		///</summary>
		
		private byte? directorStatus_;
		
		///<summary>
		/// 当前操作步骤。1:供应商,2:商务助理,3:商务经理,4:商务总监
		///</summary>
		
		private byte? stage_;
		
		///<summary>
		/// 修改时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private long? createTime_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createBy_;
		
		///<summary>
		/// 供应商对接的部门id标识
		///</summary>
		
		private int? departmentId_;
		
		///<summary>
		/// 供应商对接的商务人员id
		///</summary>
		
		private string acceptOperatorId_;
		
		///<summary>
		/// 供应商对接的商务人员名称
		///</summary>
		
		private string acceptOperator_;
		
		///<summary>
		/// 特殊审批状态。0：未到阶段,1:已通过，2：已驳回,3:待处理
		///</summary>
		
		private byte? specialStatus_;
		
		///<summary>
		/// 合同专员处理状态。0：未到阶段,1:已通过，2：已驳回,3:待处理
		///</summary>
		
		private byte? finalStatus_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌SN
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 确认函状态，1：已驳回，2：审核中，3：已完成，4：待确认，-1：未知
		///</summary>
		
		private byte? status_;
		
		///<summary>
		/// （作废，换成overseasSalesWarehouseList）档期id，历史数据继续使用
		///</summary>
		
		private int? brandId_;
		
		///<summary>
		/// 供应商对接的部门名称
		///</summary>
		
		private string departmentName_;
		
		///<summary>
		/// 活动类型/比例
		///</summary>
		
		private string scaleContent_;
		
		///<summary>
		/// 活动内容
		///</summary>
		
		private string discountContent_;
		
		///<summary>
		/// 是否在有效活动中被绑定（0：未绑定，1：活动绑定，2：优惠券绑定）
		///</summary>
		
		private byte? bindingType_;
		
		///<summary>
		/// 发起类型（1：供应商；2：商助）
		///</summary>
		
		private byte? operatorType_;
		
		///<summary>
		/// 业务类型（1：商务，2：海淘）
		///</summary>
		
		private byte? businessType_;
		
		///<summary>
		/// 确认函维度（1：专场维度，2：品牌维度）
		///</summary>
		
		private byte? contractDimension_;
		
		///<summary>
		/// 上线时间，格式为：yyyy-MM-dd HH:mm:ss，同下
		///</summary>
		
		private string onlineStarttimeFmt_;
		
		///<summary>
		/// 下线时间
		///</summary>
		
		private string onlineEndtimeFmt_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private string createTimeFmt_;
		
		///<summary>
		/// 确认函维度（1：专场维度，2：品牌维度）
		///</summary>
		
		private string contractDimensionName_;
		
		///<summary>
		/// 签约模式 （1： 普通模式， 2：电子印章，3：验证码模式）
		///</summary>
		
		private string signModeName_;
		
		///<summary>
		/// 确认函状态，1：已驳回，2：审核中，3：已完成，4：待确认，-1：未知
		///</summary>
		
		private string statusName_;
		
		///<summary>
		/// 签署公司名称
		///</summary>
		
		private string companyName_;
		
		///<summary>
		/// 确认函活动力度原始数据
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> discountList_;
		
		///<summary>
		/// 审批完成时间，finalStatus=1（已完成）时才有此值，默认为空字符串
		///</summary>
		
		private string processCompletedTimeStr_;
		
		///<summary>
		/// 专场多仓
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> salesWarehouseList_;
		
		///<summary>
		/// 专场类型。0：非专场多仓，1：专场多仓
		///</summary>
		
		private byte? overseasSalesType_;
		
		///<summary>
		/// 专场no，等价于brandId，改造为Long型，统一名称salesNo。有值条件business_type == 2 && overseas_sales_type == 0
		///</summary>
		
		private long? salesNo_;
		
		///<summary>
		/// 对接渠道。（jd：京东）
		///</summary>
		
		private string channel_;
		
		///<summary>
		/// 确认函模式（0：单一，1：混合）
		///</summary>
		
		private byte? contractMode_;
		
		///<summary>
		/// OXO合同编码
		///</summary>
		
		private string oxoContractNo_;
		
		///<summary>
		/// OXO合同名称
		///</summary>
		
		private string oxoContractName_;
		
		///<summary>
		/// OXO合同时间
		///</summary>
		
		private long? oxoContractTime_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetProtNo(){
			return this.protNo_;
		}
		
		public void SetProtNo(string value){
			this.protNo_ = value;
		}
		public int? GetCompanyId(){
			return this.companyId_;
		}
		
		public void SetCompanyId(int? value){
			this.companyId_ = value;
		}
		public string GetContractNo(){
			return this.contractNo_;
		}
		
		public void SetContractNo(string value){
			this.contractNo_ = value;
		}
		public string GetContractName(){
			return this.contractName_;
		}
		
		public void SetContractName(string value){
			this.contractName_ = value;
		}
		public long? GetContractTime(){
			return this.contractTime_;
		}
		
		public void SetContractTime(long? value){
			this.contractTime_ = value;
		}
		public byte? GetSignMode(){
			return this.signMode_;
		}
		
		public void SetSignMode(byte? value){
			this.signMode_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetSpecialName(){
			return this.specialName_;
		}
		
		public void SetSpecialName(string value){
			this.specialName_ = value;
		}
		public byte? GetRangeType(){
			return this.rangeType_;
		}
		
		public void SetRangeType(byte? value){
			this.rangeType_ = value;
		}
		public string GetActivityAlltype(){
			return this.activityAlltype_;
		}
		
		public void SetActivityAlltype(string value){
			this.activityAlltype_ = value;
		}
		public long? GetOnlineStarttime(){
			return this.onlineStarttime_;
		}
		
		public void SetOnlineStarttime(long? value){
			this.onlineStarttime_ = value;
		}
		public long? GetOnlineEndtime(){
			return this.onlineEndtime_;
		}
		
		public void SetOnlineEndtime(long? value){
			this.onlineEndtime_ = value;
		}
		public byte? GetBasicStatus(){
			return this.basicStatus_;
		}
		
		public void SetBasicStatus(byte? value){
			this.basicStatus_ = value;
		}
		public byte? GetAssistantStatus(){
			return this.assistantStatus_;
		}
		
		public void SetAssistantStatus(byte? value){
			this.assistantStatus_ = value;
		}
		public byte? GetManagerStatus(){
			return this.managerStatus_;
		}
		
		public void SetManagerStatus(byte? value){
			this.managerStatus_ = value;
		}
		public byte? GetDirectorStatus(){
			return this.directorStatus_;
		}
		
		public void SetDirectorStatus(byte? value){
			this.directorStatus_ = value;
		}
		public byte? GetStage(){
			return this.stage_;
		}
		
		public void SetStage(byte? value){
			this.stage_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		public string GetCreateBy(){
			return this.createBy_;
		}
		
		public void SetCreateBy(string value){
			this.createBy_ = value;
		}
		public int? GetDepartmentId(){
			return this.departmentId_;
		}
		
		public void SetDepartmentId(int? value){
			this.departmentId_ = value;
		}
		public string GetAcceptOperatorId(){
			return this.acceptOperatorId_;
		}
		
		public void SetAcceptOperatorId(string value){
			this.acceptOperatorId_ = value;
		}
		public string GetAcceptOperator(){
			return this.acceptOperator_;
		}
		
		public void SetAcceptOperator(string value){
			this.acceptOperator_ = value;
		}
		public byte? GetSpecialStatus(){
			return this.specialStatus_;
		}
		
		public void SetSpecialStatus(byte? value){
			this.specialStatus_ = value;
		}
		public byte? GetFinalStatus(){
			return this.finalStatus_;
		}
		
		public void SetFinalStatus(byte? value){
			this.finalStatus_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		public int? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(int? value){
			this.brandId_ = value;
		}
		public string GetDepartmentName(){
			return this.departmentName_;
		}
		
		public void SetDepartmentName(string value){
			this.departmentName_ = value;
		}
		public string GetScaleContent(){
			return this.scaleContent_;
		}
		
		public void SetScaleContent(string value){
			this.scaleContent_ = value;
		}
		public string GetDiscountContent(){
			return this.discountContent_;
		}
		
		public void SetDiscountContent(string value){
			this.discountContent_ = value;
		}
		public byte? GetBindingType(){
			return this.bindingType_;
		}
		
		public void SetBindingType(byte? value){
			this.bindingType_ = value;
		}
		public byte? GetOperatorType(){
			return this.operatorType_;
		}
		
		public void SetOperatorType(byte? value){
			this.operatorType_ = value;
		}
		public byte? GetBusinessType(){
			return this.businessType_;
		}
		
		public void SetBusinessType(byte? value){
			this.businessType_ = value;
		}
		public byte? GetContractDimension(){
			return this.contractDimension_;
		}
		
		public void SetContractDimension(byte? value){
			this.contractDimension_ = value;
		}
		public string GetOnlineStarttimeFmt(){
			return this.onlineStarttimeFmt_;
		}
		
		public void SetOnlineStarttimeFmt(string value){
			this.onlineStarttimeFmt_ = value;
		}
		public string GetOnlineEndtimeFmt(){
			return this.onlineEndtimeFmt_;
		}
		
		public void SetOnlineEndtimeFmt(string value){
			this.onlineEndtimeFmt_ = value;
		}
		public string GetCreateTimeFmt(){
			return this.createTimeFmt_;
		}
		
		public void SetCreateTimeFmt(string value){
			this.createTimeFmt_ = value;
		}
		public string GetContractDimensionName(){
			return this.contractDimensionName_;
		}
		
		public void SetContractDimensionName(string value){
			this.contractDimensionName_ = value;
		}
		public string GetSignModeName(){
			return this.signModeName_;
		}
		
		public void SetSignModeName(string value){
			this.signModeName_ = value;
		}
		public string GetStatusName(){
			return this.statusName_;
		}
		
		public void SetStatusName(string value){
			this.statusName_ = value;
		}
		public string GetCompanyName(){
			return this.companyName_;
		}
		
		public void SetCompanyName(string value){
			this.companyName_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> GetDiscountList(){
			return this.discountList_;
		}
		
		public void SetDiscountList(List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> value){
			this.discountList_ = value;
		}
		public string GetProcessCompletedTimeStr(){
			return this.processCompletedTimeStr_;
		}
		
		public void SetProcessCompletedTimeStr(string value){
			this.processCompletedTimeStr_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> GetSalesWarehouseList(){
			return this.salesWarehouseList_;
		}
		
		public void SetSalesWarehouseList(List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> value){
			this.salesWarehouseList_ = value;
		}
		public byte? GetOverseasSalesType(){
			return this.overseasSalesType_;
		}
		
		public void SetOverseasSalesType(byte? value){
			this.overseasSalesType_ = value;
		}
		public long? GetSalesNo(){
			return this.salesNo_;
		}
		
		public void SetSalesNo(long? value){
			this.salesNo_ = value;
		}
		public string GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(string value){
			this.channel_ = value;
		}
		public byte? GetContractMode(){
			return this.contractMode_;
		}
		
		public void SetContractMode(byte? value){
			this.contractMode_ = value;
		}
		public string GetOxoContractNo(){
			return this.oxoContractNo_;
		}
		
		public void SetOxoContractNo(string value){
			this.oxoContractNo_ = value;
		}
		public string GetOxoContractName(){
			return this.oxoContractName_;
		}
		
		public void SetOxoContractName(string value){
			this.oxoContractName_ = value;
		}
		public long? GetOxoContractTime(){
			return this.oxoContractTime_;
		}
		
		public void SetOxoContractTime(long? value){
			this.oxoContractTime_ = value;
		}
		
	}
	
}