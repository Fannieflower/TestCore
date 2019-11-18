using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActConditionModel {
		
		///<summary>
		/// 0：仅购物流程展示（只有在购物车才展示优惠文案）1：全部地方都展示（首页，列表页，详情页，购物车都展示优惠文案）
		///</summary>
		
		private int? display_;
		
		///<summary>
		/// 参加次数限制
		///</summary>
		
		private int? peopleNumLimit_;
		
		///<summary>
		/// 指明活动源amount的计算方式：1: 按数量计算 - amount为数量 2: 按金额计算 - amount为金额
		///</summary>
		
		private int? giveType_;
		
		///<summary>
		/// 1: 赠品ID(sizeid) 2: 赠品-券ID
		///</summary>
		
		private int? giftType_;
		
		///<summary>
		/// 生日赠
		///</summary>
		
		private int? actGiftType_;
		
		///<summary>
		/// 是否允许重复
		///</summary>
		
		private int? isAllowRepeat_;
		
		///<summary>
		/// 会员类型列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerSrcList_;
		
		///<summary>
		/// 会员等级列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerLevelList_;
		
		///<summary>
		/// 会员企业类型
		///</summary>
		
		private int? enterpriseType_;
		
		///<summary>
		/// 预付优惠类型
		///</summary>
		
		private string prepayFavType_;
		
		///<summary>
		/// 麦肯锡买赠标签
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> mcKinseyList_;
		
		///<summary>
		/// 麦肯锡免邮标签
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> mcKinsey2List_;
		
		///<summary>
		/// 用户标签列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> customerTagList_;
		
		///<summary>
		/// 会员企业列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> enterpriseList_;
		
		///<summary>
		/// 渠道来源 列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> mobileChannelList_;
		
		///<summary>
		/// 重复上限
		///</summary>
		
		private double? repeatAmountLimit_;
		
		///<summary>
		/// 会员免邮标签
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActConfigModel> freeCarriageList_;
		
		///<summary>
		/// 受众配置
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActAudienceConfigModel> audienceConfigList_;
		
		///<summary>
		/// 单最大购买商品数量
		///</summary>
		
		private int? buyLimit_;
		
		public int? GetDisplay(){
			return this.display_;
		}
		
		public void SetDisplay(int? value){
			this.display_ = value;
		}
		public int? GetPeopleNumLimit(){
			return this.peopleNumLimit_;
		}
		
		public void SetPeopleNumLimit(int? value){
			this.peopleNumLimit_ = value;
		}
		public int? GetGiveType(){
			return this.giveType_;
		}
		
		public void SetGiveType(int? value){
			this.giveType_ = value;
		}
		public int? GetGiftType(){
			return this.giftType_;
		}
		
		public void SetGiftType(int? value){
			this.giftType_ = value;
		}
		public int? GetActGiftType(){
			return this.actGiftType_;
		}
		
		public void SetActGiftType(int? value){
			this.actGiftType_ = value;
		}
		public int? GetIsAllowRepeat(){
			return this.isAllowRepeat_;
		}
		
		public void SetIsAllowRepeat(int? value){
			this.isAllowRepeat_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerSrcList(){
			return this.customerSrcList_;
		}
		
		public void SetCustomerSrcList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerSrcList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerLevelList(){
			return this.customerLevelList_;
		}
		
		public void SetCustomerLevelList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerLevelList_ = value;
		}
		public int? GetEnterpriseType(){
			return this.enterpriseType_;
		}
		
		public void SetEnterpriseType(int? value){
			this.enterpriseType_ = value;
		}
		public string GetPrepayFavType(){
			return this.prepayFavType_;
		}
		
		public void SetPrepayFavType(string value){
			this.prepayFavType_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetMcKinseyList(){
			return this.mcKinseyList_;
		}
		
		public void SetMcKinseyList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.mcKinseyList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetMcKinsey2List(){
			return this.mcKinsey2List_;
		}
		
		public void SetMcKinsey2List(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.mcKinsey2List_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetCustomerTagList(){
			return this.customerTagList_;
		}
		
		public void SetCustomerTagList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.customerTagList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetEnterpriseList(){
			return this.enterpriseList_;
		}
		
		public void SetEnterpriseList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.enterpriseList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetMobileChannelList(){
			return this.mobileChannelList_;
		}
		
		public void SetMobileChannelList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.mobileChannelList_ = value;
		}
		public double? GetRepeatAmountLimit(){
			return this.repeatAmountLimit_;
		}
		
		public void SetRepeatAmountLimit(double? value){
			this.repeatAmountLimit_ = value;
		}
		public List<com.vip.pms.data.service.PmsActConfigModel> GetFreeCarriageList(){
			return this.freeCarriageList_;
		}
		
		public void SetFreeCarriageList(List<com.vip.pms.data.service.PmsActConfigModel> value){
			this.freeCarriageList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActAudienceConfigModel> GetAudienceConfigList(){
			return this.audienceConfigList_;
		}
		
		public void SetAudienceConfigList(List<com.vip.pms.data.service.PmsActAudienceConfigModel> value){
			this.audienceConfigList_ = value;
		}
		public int? GetBuyLimit(){
			return this.buyLimit_;
		}
		
		public void SetBuyLimit(int? value){
			this.buyLimit_ = value;
		}
		
	}
	
}