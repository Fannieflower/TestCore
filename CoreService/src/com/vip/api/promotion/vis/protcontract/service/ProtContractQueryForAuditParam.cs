using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractQueryForAuditParam {
		
		///<summary>
		/// 确认函编号（支持批量查询）
		///</summary>
		
		private List<string> protNos_;
		
		///<summary>
		/// 活动类型（1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动）
		///</summary>
		
		private string activityAlltype_;
		
		///<summary>
		/// 签约模式 （1： 普通模式， 2：电子印章，3：验证码模式）
		///</summary>
		
		private byte? signMode_;
		
		///<summary>
		/// 上线时间查询开始区间
		///</summary>
		
		private long? onlineStarttimeStart_;
		
		///<summary>
		/// 上线时间查询结束区间
		///</summary>
		
		private long? onlineStarttimeEnd_;
		
		///<summary>
		/// 下线时间查询开始区间
		///</summary>
		
		private long? onlineEndtimeStart_;
		
		///<summary>
		/// 下线时间查询结束区间
		///</summary>
		
		private long? onlineEndtimeEnd_;
		
		///<summary>
		/// 供应商code（支持批量查询）
		///</summary>
		
		private List<string> vendorCodes_;
		
		///<summary>
		/// 供应商名称（精确查询）
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 活动范围（4:特卖会（含PC + APP + WAP + 唯品会旗舰店（京东）+ 微Q端（京东））,5:其他（花海仓、乐蜂等APP））
		///</summary>
		
		private byte? rangeType_;
		
		///<summary>
		/// 当前操作步骤（1:供应商,2:商务助理,3:商务经理,4:商务总监,5:特殊审批,6:专员确认）
		///</summary>
		
		private byte? stage_;
		
		///<summary>
		/// 确认函审批状态（1：待商务助理审核，2：待商务经理审核，3：待商务总监审核，4：已完成，5：不通过，6：待确认，7：已完成（特殊审批））
		///</summary>
		
		private byte? auditStatus_;
		
		///<summary>
		/// 数据范围（2：我可见部门的，3：我经办的，4：指派给我的）
		///</summary>
		
		private byte? dataRange_;
		
		///<summary>
		/// 查询用户数据权限
		///</summary>
		
		private List<string> dataAreaIds_;
		
		///<summary>
		/// 查询用户Email
		///</summary>
		
		private string userEmail_;
		
		///<summary>
		/// 查询用户id
		///</summary>
		
		private int? userId_;
		
		///<summary>
		/// 品牌SN
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 是否匹配确认函中档期发起人
		///</summary>
		
		private bool? matchScheduleCreator_;
		
		///<summary>
		/// 排序（默认按修改时间倒序，1：按id倒序，2：按id顺序，3：按上线时间倒序，4：按上线时间顺序，5：按下线时间倒序，6：按下线时间顺序）
		///</summary>
		
		private byte? orderBy_;
		
		///<summary>
		/// 专场名称
		///</summary>
		
		private string specialName_;
		
		///<summary>
		/// 承担方式（1：比例，2：固定金额，3：返利，4：扣点变更）
		///</summary>
		
		private List<byte?> bearType_;
		
		///<summary>
		/// 业务类型（1：商务，2：海淘），不填写时默认查询所有
		///</summary>
		
		private byte? businessType_;
		
		///<summary>
		/// 确认函维度（1：专场维度，2：品牌维度，3：商品维度），不填写时默认查询所有
		///</summary>
		
		private byte? contractDimension_;
		
		///<summary>
		/// 确认函模式（0：单一，1：混合）
		///</summary>
		
		private byte? contractMode_;
		
		public List<string> GetProtNos(){
			return this.protNos_;
		}
		
		public void SetProtNos(List<string> value){
			this.protNos_ = value;
		}
		public string GetActivityAlltype(){
			return this.activityAlltype_;
		}
		
		public void SetActivityAlltype(string value){
			this.activityAlltype_ = value;
		}
		public byte? GetSignMode(){
			return this.signMode_;
		}
		
		public void SetSignMode(byte? value){
			this.signMode_ = value;
		}
		public long? GetOnlineStarttimeStart(){
			return this.onlineStarttimeStart_;
		}
		
		public void SetOnlineStarttimeStart(long? value){
			this.onlineStarttimeStart_ = value;
		}
		public long? GetOnlineStarttimeEnd(){
			return this.onlineStarttimeEnd_;
		}
		
		public void SetOnlineStarttimeEnd(long? value){
			this.onlineStarttimeEnd_ = value;
		}
		public long? GetOnlineEndtimeStart(){
			return this.onlineEndtimeStart_;
		}
		
		public void SetOnlineEndtimeStart(long? value){
			this.onlineEndtimeStart_ = value;
		}
		public long? GetOnlineEndtimeEnd(){
			return this.onlineEndtimeEnd_;
		}
		
		public void SetOnlineEndtimeEnd(long? value){
			this.onlineEndtimeEnd_ = value;
		}
		public List<string> GetVendorCodes(){
			return this.vendorCodes_;
		}
		
		public void SetVendorCodes(List<string> value){
			this.vendorCodes_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public byte? GetRangeType(){
			return this.rangeType_;
		}
		
		public void SetRangeType(byte? value){
			this.rangeType_ = value;
		}
		public byte? GetStage(){
			return this.stage_;
		}
		
		public void SetStage(byte? value){
			this.stage_ = value;
		}
		public byte? GetAuditStatus(){
			return this.auditStatus_;
		}
		
		public void SetAuditStatus(byte? value){
			this.auditStatus_ = value;
		}
		public byte? GetDataRange(){
			return this.dataRange_;
		}
		
		public void SetDataRange(byte? value){
			this.dataRange_ = value;
		}
		public List<string> GetDataAreaIds(){
			return this.dataAreaIds_;
		}
		
		public void SetDataAreaIds(List<string> value){
			this.dataAreaIds_ = value;
		}
		public string GetUserEmail(){
			return this.userEmail_;
		}
		
		public void SetUserEmail(string value){
			this.userEmail_ = value;
		}
		public int? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(int? value){
			this.userId_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public bool? GetMatchScheduleCreator(){
			return this.matchScheduleCreator_;
		}
		
		public void SetMatchScheduleCreator(bool? value){
			this.matchScheduleCreator_ = value;
		}
		public byte? GetOrderBy(){
			return this.orderBy_;
		}
		
		public void SetOrderBy(byte? value){
			this.orderBy_ = value;
		}
		public string GetSpecialName(){
			return this.specialName_;
		}
		
		public void SetSpecialName(string value){
			this.specialName_ = value;
		}
		public List<byte?> GetBearType(){
			return this.bearType_;
		}
		
		public void SetBearType(List<byte?> value){
			this.bearType_ = value;
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
		public byte? GetContractMode(){
			return this.contractMode_;
		}
		
		public void SetContractMode(byte? value){
			this.contractMode_ = value;
		}
		
	}
	
}