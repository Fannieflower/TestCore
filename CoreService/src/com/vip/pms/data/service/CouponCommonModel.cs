using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponCommonModel {
		
		///<summary>
		/// 优惠券号
		///</summary>
		
		private string id_;
		
		///<summary>
		/// 优惠券名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 券范围 专场/档期3 全场5 品类7
		///</summary>
		
		private int? range_;
		
		///<summary>
		/// 优惠类型 2 满减 4 免邮
		///</summary>
		
		private int? offersType_;
		
		///<summary>
		/// 限制额度类型 1按产品数量 2 按金额
		///</summary>
		
		private int? giveType_;
		
		///<summary>
		/// 限制额度
		///</summary>
		
		private double? buy_;
		
		///<summary>
		/// 优惠额度
		///</summary>
		
		private double? offer_;
		
		///<summary>
		/// 是否在线支付券
		///</summary>
		
		private bool? isOnlinePay_;
		
		///<summary>
		/// 是否启用黑名单
		///</summary>
		
		private bool? isAllowBlackList_;
		
		///<summary>
		/// 使用开始时间
		///</summary>
		
		private long? useBeginTime_;
		
		///<summary>
		/// 使用结束时间
		///</summary>
		
		private long? useEndTime_;
		
		///<summary>
		/// 适用平台
		///</summary>
		
		private List<string> platformList_;
		
		///<summary>
		/// 专场列表
		///</summary>
		
		private List<com.vip.pms.data.service.CouponRangeModel> rangeList_;
		
		///<summary>
		/// 模式 0自营 1直发 2海淘
		///</summary>
		
		private List<string> saleModelList_;
		
		///<summary>
		/// 组合券中，派发该优惠券数量 不是组合券可不填
		///</summary>
		
		private int? sendNum_;
		
		///<summary>
		/// 分类导航ID 非品类券不填
		///</summary>
		
		private string categoryChannelId_;
		
		///<summary>
		/// 品类列表 非品类券不填
		///</summary>
		
		private List<com.vip.pms.data.service.CouponRangeModel> categoryList_;
		
		///<summary>
		/// 组合券中成员券的盐 不是组合券不填
		///</summary>
		
		private string salt_;
		
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
		public int? GetRange(){
			return this.range_;
		}
		
		public void SetRange(int? value){
			this.range_ = value;
		}
		public int? GetOffersType(){
			return this.offersType_;
		}
		
		public void SetOffersType(int? value){
			this.offersType_ = value;
		}
		public int? GetGiveType(){
			return this.giveType_;
		}
		
		public void SetGiveType(int? value){
			this.giveType_ = value;
		}
		public double? GetBuy(){
			return this.buy_;
		}
		
		public void SetBuy(double? value){
			this.buy_ = value;
		}
		public double? GetOffer(){
			return this.offer_;
		}
		
		public void SetOffer(double? value){
			this.offer_ = value;
		}
		public bool? GetIsOnlinePay(){
			return this.isOnlinePay_;
		}
		
		public void SetIsOnlinePay(bool? value){
			this.isOnlinePay_ = value;
		}
		public bool? GetIsAllowBlackList(){
			return this.isAllowBlackList_;
		}
		
		public void SetIsAllowBlackList(bool? value){
			this.isAllowBlackList_ = value;
		}
		public long? GetUseBeginTime(){
			return this.useBeginTime_;
		}
		
		public void SetUseBeginTime(long? value){
			this.useBeginTime_ = value;
		}
		public long? GetUseEndTime(){
			return this.useEndTime_;
		}
		
		public void SetUseEndTime(long? value){
			this.useEndTime_ = value;
		}
		public List<string> GetPlatformList(){
			return this.platformList_;
		}
		
		public void SetPlatformList(List<string> value){
			this.platformList_ = value;
		}
		public List<com.vip.pms.data.service.CouponRangeModel> GetRangeList(){
			return this.rangeList_;
		}
		
		public void SetRangeList(List<com.vip.pms.data.service.CouponRangeModel> value){
			this.rangeList_ = value;
		}
		public List<string> GetSaleModelList(){
			return this.saleModelList_;
		}
		
		public void SetSaleModelList(List<string> value){
			this.saleModelList_ = value;
		}
		public int? GetSendNum(){
			return this.sendNum_;
		}
		
		public void SetSendNum(int? value){
			this.sendNum_ = value;
		}
		public string GetCategoryChannelId(){
			return this.categoryChannelId_;
		}
		
		public void SetCategoryChannelId(string value){
			this.categoryChannelId_ = value;
		}
		public List<com.vip.pms.data.service.CouponRangeModel> GetCategoryList(){
			return this.categoryList_;
		}
		
		public void SetCategoryList(List<com.vip.pms.data.service.CouponRangeModel> value){
			this.categoryList_ = value;
		}
		public string GetSalt(){
			return this.salt_;
		}
		
		public void SetSalt(string value){
			this.salt_ = value;
		}
		
	}
	
}