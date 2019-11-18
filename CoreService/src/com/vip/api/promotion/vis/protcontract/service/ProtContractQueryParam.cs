using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractQueryParam {
		
		///<summary>
		/// 确认函编号（支持批量查询）
		///</summary>
		
		private List<string> protNos_;
		
		///<summary>
		/// 活动类型（1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动）
		///</summary>
		
		private string activityAlltype_;
		
		///<summary>
		/// 确认函状态（1：已驳回，2：审核中，3：已完成，4：待确认）
		///</summary>
		
		private byte? status_;
		
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
		/// 活动范围（4:特卖会（含PC + APP + WAP + 唯品会旗舰店（京东）+ 微Q端（京东））,5:其他（花海仓、乐蜂等APP））
		///</summary>
		
		private byte? rangeType_;
		
		///<summary>
		/// 当前操作步骤（1:供应商,2:商务助理,3:商务经理,4:商务总监,5:特殊审批,6:专员确认）
		///</summary>
		
		private byte? stage_;
		
		///<summary>
		/// 查询用户数据权限
		///</summary>
		
		private List<string> dataAreaIds_;
		
		///<summary>
		/// 排序（默认按修改时间倒序，1：按id倒序，2：按id顺序，3：按上线时间倒序，4：按上线时间顺序，5：按下线时间倒序，6：按下线时间顺序）
		///</summary>
		
		private byte? orderBy_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 专场ID
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 销售主题名称
		///</summary>
		
		private string specialName_;
		
		///<summary>
		/// 基础状态（字段作废）
		///</summary>
		
		private byte? basicStatus_;
		
		///<summary>
		/// 活动开始时间
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 活动结束时间
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 发起类型（1：供应商；2：商助），不填写时默认查询所有
		///</summary>
		
		private byte? operatorType_;
		
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
		
		///<summary>
		/// 确认函id列表
		///</summary>
		
		private List<long?> contractIds_;
		
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
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
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
		public List<string> GetDataAreaIds(){
			return this.dataAreaIds_;
		}
		
		public void SetDataAreaIds(List<string> value){
			this.dataAreaIds_ = value;
		}
		public byte? GetOrderBy(){
			return this.orderBy_;
		}
		
		public void SetOrderBy(byte? value){
			this.orderBy_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public string GetSpecialName(){
			return this.specialName_;
		}
		
		public void SetSpecialName(string value){
			this.specialName_ = value;
		}
		public byte? GetBasicStatus(){
			return this.basicStatus_;
		}
		
		public void SetBasicStatus(byte? value){
			this.basicStatus_ = value;
		}
		public long? GetBeginTime(){
			return this.beginTime_;
		}
		
		public void SetBeginTime(long? value){
			this.beginTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
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
		public byte? GetContractMode(){
			return this.contractMode_;
		}
		
		public void SetContractMode(byte? value){
			this.contractMode_ = value;
		}
		public List<long?> GetContractIds(){
			return this.contractIds_;
		}
		
		public void SetContractIds(List<long?> value){
			this.contractIds_ = value;
		}
		
	}
	
}