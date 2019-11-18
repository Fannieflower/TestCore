using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponCoreModel {
		
		///<summary>
		/// 优惠券通用参数
		///</summary>
		
		private com.vip.pms.data.service.CouponCommonModel couponCommonModel_;
		
		///<summary>
		/// 获取途径
		///</summary>
		
		private string msgGet_;
		
		///<summary>
		/// 适用渠道
		///</summary>
		
		private string channel_;
		
		///<summary>
		/// 券类型 1 个性码 2 统一码
		///</summary>
		
		private int? couponType_;
		
		///<summary>
		/// 券号 统一码时使用
		///</summary>
		
		private string couponCode_;
		
		///<summary>
		/// 派发类型 1:导出 2:线上派发 3:虚拟赠品 4:批量派发 5:动态金额绑定
		///</summary>
		
		private int? deliveryType_;
		
		///<summary>
		/// 容许派发数量
		///</summary>
		
		private int? deliveryNum_;
		
		///<summary>
		/// 每个用户限定的激活数量
		///</summary>
		
		private int? userBindLimit_;
		
		///<summary>
		/// 限制时间类型 1 绝对时间 2 相对时间
		///</summary>
		
		private int? useTimeType_;
		
		///<summary>
		/// 使用相对时间有效期
		///</summary>
		
		private int? relativeDays_;
		
		///<summary>
		/// 随机码
		///</summary>
		
		private string salt_;
		
		///<summary>
		/// 是否新客优惠
		///</summary>
		
		private bool? isNewCoupon_;
		
		///<summary>
		/// 激活开始时间
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 激活结束时间
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// -1:已取消, 0已下线; 1正常
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 用户标签
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActAudienceConfigModel> userTagList_;
		
		///<summary>
		/// 会员属性(包含属性)
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActAudienceConfigModel> memberPropList_;
		
		public com.vip.pms.data.service.CouponCommonModel GetCouponCommonModel(){
			return this.couponCommonModel_;
		}
		
		public void SetCouponCommonModel(com.vip.pms.data.service.CouponCommonModel value){
			this.couponCommonModel_ = value;
		}
		public string GetMsgGet(){
			return this.msgGet_;
		}
		
		public void SetMsgGet(string value){
			this.msgGet_ = value;
		}
		public string GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(string value){
			this.channel_ = value;
		}
		public int? GetCouponType(){
			return this.couponType_;
		}
		
		public void SetCouponType(int? value){
			this.couponType_ = value;
		}
		public string GetCouponCode(){
			return this.couponCode_;
		}
		
		public void SetCouponCode(string value){
			this.couponCode_ = value;
		}
		public int? GetDeliveryType(){
			return this.deliveryType_;
		}
		
		public void SetDeliveryType(int? value){
			this.deliveryType_ = value;
		}
		public int? GetDeliveryNum(){
			return this.deliveryNum_;
		}
		
		public void SetDeliveryNum(int? value){
			this.deliveryNum_ = value;
		}
		public int? GetUserBindLimit(){
			return this.userBindLimit_;
		}
		
		public void SetUserBindLimit(int? value){
			this.userBindLimit_ = value;
		}
		public int? GetUseTimeType(){
			return this.useTimeType_;
		}
		
		public void SetUseTimeType(int? value){
			this.useTimeType_ = value;
		}
		public int? GetRelativeDays(){
			return this.relativeDays_;
		}
		
		public void SetRelativeDays(int? value){
			this.relativeDays_ = value;
		}
		public string GetSalt(){
			return this.salt_;
		}
		
		public void SetSalt(string value){
			this.salt_ = value;
		}
		public bool? GetIsNewCoupon(){
			return this.isNewCoupon_;
		}
		
		public void SetIsNewCoupon(bool? value){
			this.isNewCoupon_ = value;
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
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public List<com.vip.pms.data.service.PmsActAudienceConfigModel> GetUserTagList(){
			return this.userTagList_;
		}
		
		public void SetUserTagList(List<com.vip.pms.data.service.PmsActAudienceConfigModel> value){
			this.userTagList_ = value;
		}
		public List<com.vip.pms.data.service.PmsActAudienceConfigModel> GetMemberPropList(){
			return this.memberPropList_;
		}
		
		public void SetMemberPropList(List<com.vip.pms.data.service.PmsActAudienceConfigModel> value){
			this.memberPropList_ = value;
		}
		
	}
	
}