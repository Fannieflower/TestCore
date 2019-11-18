using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponGroupCoreModel {
		
		///<summary>
		/// 组合券号
		///</summary>
		
		private string id_;
		
		///<summary>
		/// 组合券名称
		///</summary>
		
		private string name_;
		
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
		/// 派发组数
		///</summary>
		
		private int? sendNum_;
		
		///<summary>
		/// 每个用户限定的领取数量
		///</summary>
		
		private int? userBindLimit_;
		
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
		/// 导入的优惠券列表
		///</summary>
		
		private List<com.vip.pms.data.service.CouponCommonModel> couponCommonModelList_;
		
		///<summary>
		/// -1:已取消, 0已下线; 1正常
		///</summary>
		
		private int? status_;
		
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
		public int? GetSendNum(){
			return this.sendNum_;
		}
		
		public void SetSendNum(int? value){
			this.sendNum_ = value;
		}
		public int? GetUserBindLimit(){
			return this.userBindLimit_;
		}
		
		public void SetUserBindLimit(int? value){
			this.userBindLimit_ = value;
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
		public List<com.vip.pms.data.service.CouponCommonModel> GetCouponCommonModelList(){
			return this.couponCommonModelList_;
		}
		
		public void SetCouponCommonModelList(List<com.vip.pms.data.service.CouponCommonModel> value){
			this.couponCommonModelList_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		
	}
	
}