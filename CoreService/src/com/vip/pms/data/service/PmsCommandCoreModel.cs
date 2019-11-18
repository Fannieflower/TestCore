using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsCommandCoreModel {
		
		///<summary>
		/// 口令红包编号
		///</summary>
		
		private string id_;
		
		///<summary>
		/// 口令红包名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 口令编码
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 口令红包优惠类型 2满减 3折扣
		///</summary>
		
		private int? rpType_;
		
		///<summary>
		/// 活动平台 只有1
		///</summary>
		
		private int? channel_;
		
		///<summary>
		/// 营销对象类型 3专场组合 5全场
		///</summary>
		
		private int? range_;
		
		///<summary>
		/// 参加次数限制
		///</summary>
		
		private int? totalLimit_;
		
		///<summary>
		/// 参加次数限制
		///</summary>
		
		private int? userLimit_;
		
		///<summary>
		/// 最大优惠数量或金额（pms_red_packet_main.price_limit）
		///</summary>
		
		private double? priceLimit_;
		
		///<summary>
		/// 是否不限制用户可用次数(pms_red_packet_config.config_type=4的值)
		///</summary>
		
		private bool? notLimitUser_;
		
		///<summary>
		/// 废弃，不再使用！该字段仍为required，调用方需要填一个随意值
		///是否上不封顶 true:上封顶 false:上不封顶
		///</summary>
		
		private bool? isAllowRepeatConfig_;
		
		///<summary>
		/// 是否重复计算 0：不重复优惠 1：重复优惠
		///</summary>
		
		private int? isAllowRepeat_;
		
		///<summary>
		/// 开始时间 包含本时间点
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 结束时间 包含本时间点
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 优惠条件类型 1: 按数量计算 - amount为数量  2: 按金额计算 - amount为金额
		///</summary>
		
		private int? favType_;
		
		///<summary>
		/// 会员等级列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerLevelList_;
		
		///<summary>
		/// 销售模式列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> saleModelList_;
		
		///<summary>
		/// 是否激活黑名单
		///</summary>
		
		private bool? isAllowBlackList_;
		
		///<summary>
		/// 优惠方式
		///</summary>
		
		private List<com.vip.pms.data.service.PmsCommandFavModel> commandFavList_;
		
		///<summary>
		/// 专场列表 pms_red_packet_scope.scope_id
		///</summary>
		
		private List<string> commandScopeList_;
		
		///<summary>
		/// 会员类型列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerSrcList_;
		
		///<summary>
		/// 口令红包父编号
		///</summary>
		
		private string parentId_;
		
		///<summary>
		/// 用户类型：1-新老客、相同优惠力度；2-新客；3-老客；不传默认是1
		///</summary>
		
		private int? userType_;
		
		///<summary>
		/// 受众配置
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActAudienceConfigModel> audienceConfigList_;
		
		public string GetId(){
			return this.id_;
		}
		
		public void SetId(string value){
			this.id_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public int? GetRpType(){
			return this.rpType_;
		}
		
		public void SetRpType(int? value){
			this.rpType_ = value;
		}
		public int? GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(int? value){
			this.channel_ = value;
		}
		public int? GetRange(){
			return this.range_;
		}
		
		public void SetRange(int? value){
			this.range_ = value;
		}
		public int? GetTotalLimit(){
			return this.totalLimit_;
		}
		
		public void SetTotalLimit(int? value){
			this.totalLimit_ = value;
		}
		public int? GetUserLimit(){
			return this.userLimit_;
		}
		
		public void SetUserLimit(int? value){
			this.userLimit_ = value;
		}
		public double? GetPriceLimit(){
			return this.priceLimit_;
		}
		
		public void SetPriceLimit(double? value){
			this.priceLimit_ = value;
		}
		public bool? GetNotLimitUser(){
			return this.notLimitUser_;
		}
		
		public void SetNotLimitUser(bool? value){
			this.notLimitUser_ = value;
		}
		public bool? GetIsAllowRepeatConfig(){
			return this.isAllowRepeatConfig_;
		}
		
		public void SetIsAllowRepeatConfig(bool? value){
			this.isAllowRepeatConfig_ = value;
		}
		public int? GetIsAllowRepeat(){
			return this.isAllowRepeat_;
		}
		
		public void SetIsAllowRepeat(int? value){
			this.isAllowRepeat_ = value;
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
		public int? GetFavType(){
			return this.favType_;
		}
		
		public void SetFavType(int? value){
			this.favType_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerLevelList(){
			return this.customerLevelList_;
		}
		
		public void SetCustomerLevelList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerLevelList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetSaleModelList(){
			return this.saleModelList_;
		}
		
		public void SetSaleModelList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.saleModelList_ = value;
		}
		public bool? GetIsAllowBlackList(){
			return this.isAllowBlackList_;
		}
		
		public void SetIsAllowBlackList(bool? value){
			this.isAllowBlackList_ = value;
		}
		public List<com.vip.pms.data.service.PmsCommandFavModel> GetCommandFavList(){
			return this.commandFavList_;
		}
		
		public void SetCommandFavList(List<com.vip.pms.data.service.PmsCommandFavModel> value){
			this.commandFavList_ = value;
		}
		public List<string> GetCommandScopeList(){
			return this.commandScopeList_;
		}
		
		public void SetCommandScopeList(List<string> value){
			this.commandScopeList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerSrcList(){
			return this.customerSrcList_;
		}
		
		public void SetCustomerSrcList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerSrcList_ = value;
		}
		public string GetParentId(){
			return this.parentId_;
		}
		
		public void SetParentId(string value){
			this.parentId_ = value;
		}
		public int? GetUserType(){
			return this.userType_;
		}
		
		public void SetUserType(int? value){
			this.userType_ = value;
		}
		public List<com.vip.pms.data.service.PmsActAudienceConfigModel> GetAudienceConfigList(){
			return this.audienceConfigList_;
		}
		
		public void SetAudienceConfigList(List<com.vip.pms.data.service.PmsActAudienceConfigModel> value){
			this.audienceConfigList_ = value;
		}
		
	}
	
}