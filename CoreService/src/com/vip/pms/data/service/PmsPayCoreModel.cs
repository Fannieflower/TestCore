using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsPayCoreModel {
		
		///<summary>
		/// 活动类型 2满减 3折扣
		///</summary>
		
		private int? actType_;
		
		///<summary>
		/// 支付优惠名称
		///</summary>
		
		private string actName_;
		
		///<summary>
		/// 是否首单才能享受优惠 0: 否 1:是  满减用pms_active_full_reduce_condition，折扣用pms_active_discount_condition
		///</summary>
		
		private int? firstOrder_;
		
		///<summary>
		/// 是否允许重复 0: 否 1:是 满减用pms_active_full_reduce_condition，折扣用pms_active_discount_condition
		///</summary>
		
		private int? isAllowRepeat_;
		
		///<summary>
		/// 总参加次数限制 participate_num
		///</summary>
		
		private int? participateNum_;
		
		///<summary>
		/// 单个会员总参加次数限制
		///</summary>
		
		private int? peopleNumLimit_;
		
		///<summary>
		/// 显示标题为广告 0: 否 1:是
		///</summary>
		
		private int? showAd_;
		
		///<summary>
		/// 开始时间 包含本时间点
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 结束时间 包含本时间点
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 会员类型列表 取pms_active_condition_base_detail.base_detail_id
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerSrcList_;
		
		///<summary>
		/// 用户标签列表 取pms_active_condition_base_detail.message
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerTagList_;
		
		///<summary>
		/// 分仓--目前只有一个
		///</summary>
		
		private List<com.vip.pms.data.service.PmsPayHouseModel> payHouseList_;
		
		///<summary>
		/// 参与活动的支付方式 取pms_active_condition_base_detail.base_detail_id
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> payDetailList_;
		
		///<summary>
		/// 提示语
		///</summary>
		
		private string actMsg_;
		
		///<summary>
		/// 是否进行黑名单过滤 0: 否 1:是 默认0
		///</summary>
		
		private int? isBlackFilter_;
		
		///<summary>
		/// 黑名单提示语
		///</summary>
		
		private string blackFilterMsg_;
		
		///<summary>
		/// 是否参与分类黑名单的过滤 0: 否 1:是 默认0
		///</summary>
		
		private int? isCategoryBlackFilter_;
		
		///<summary>
		/// 受众配置
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActAudienceConfigModel> audienceConfigList_;
		
		public int? GetActType(){
			return this.actType_;
		}
		
		public void SetActType(int? value){
			this.actType_ = value;
		}
		public string GetActName(){
			return this.actName_;
		}
		
		public void SetActName(string value){
			this.actName_ = value;
		}
		public int? GetFirstOrder(){
			return this.firstOrder_;
		}
		
		public void SetFirstOrder(int? value){
			this.firstOrder_ = value;
		}
		public int? GetIsAllowRepeat(){
			return this.isAllowRepeat_;
		}
		
		public void SetIsAllowRepeat(int? value){
			this.isAllowRepeat_ = value;
		}
		public int? GetParticipateNum(){
			return this.participateNum_;
		}
		
		public void SetParticipateNum(int? value){
			this.participateNum_ = value;
		}
		public int? GetPeopleNumLimit(){
			return this.peopleNumLimit_;
		}
		
		public void SetPeopleNumLimit(int? value){
			this.peopleNumLimit_ = value;
		}
		public int? GetShowAd(){
			return this.showAd_;
		}
		
		public void SetShowAd(int? value){
			this.showAd_ = value;
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
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerSrcList(){
			return this.customerSrcList_;
		}
		
		public void SetCustomerSrcList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerSrcList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerTagList(){
			return this.customerTagList_;
		}
		
		public void SetCustomerTagList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerTagList_ = value;
		}
		public List<com.vip.pms.data.service.PmsPayHouseModel> GetPayHouseList(){
			return this.payHouseList_;
		}
		
		public void SetPayHouseList(List<com.vip.pms.data.service.PmsPayHouseModel> value){
			this.payHouseList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetPayDetailList(){
			return this.payDetailList_;
		}
		
		public void SetPayDetailList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.payDetailList_ = value;
		}
		public string GetActMsg(){
			return this.actMsg_;
		}
		
		public void SetActMsg(string value){
			this.actMsg_ = value;
		}
		public int? GetIsBlackFilter(){
			return this.isBlackFilter_;
		}
		
		public void SetIsBlackFilter(int? value){
			this.isBlackFilter_ = value;
		}
		public string GetBlackFilterMsg(){
			return this.blackFilterMsg_;
		}
		
		public void SetBlackFilterMsg(string value){
			this.blackFilterMsg_ = value;
		}
		public int? GetIsCategoryBlackFilter(){
			return this.isCategoryBlackFilter_;
		}
		
		public void SetIsCategoryBlackFilter(int? value){
			this.isCategoryBlackFilter_ = value;
		}
		public List<com.vip.pms.data.service.PmsActAudienceConfigModel> GetAudienceConfigList(){
			return this.audienceConfigList_;
		}
		
		public void SetAudienceConfigList(List<com.vip.pms.data.service.PmsActAudienceConfigModel> value){
			this.audienceConfigList_ = value;
		}
		
	}
	
}