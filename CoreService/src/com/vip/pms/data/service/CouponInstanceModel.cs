using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponInstanceModel {
		
		///<summary>
		/// 自增主键
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 券批次号
		///</summary>
		
		private string couponNo_;
		
		///<summary>
		/// 券号
		///</summary>
		
		private string couponSn_;
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 派发组类型：1：普通券 2：组合券
		///</summary>
		
		private byte? groupType_;
		
		///<summary>
		/// 激活时间
		///</summary>
		
		private long? activateTime_;
		
		///<summary>
		/// 使用时间
		///</summary>
		
		private long? useTime_;
		
		///<summary>
		/// 开始时间
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 结束时间
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 送券绑定的订单号
		///</summary>
		
		private string bindOrderSn_;
		
		///<summary>
		/// 限制使用的最低金额
		///</summary>
		
		private double? useLimit_;
		
		///<summary>
		/// 优惠金额
		///</summary>
		
		private double? favAmount_;
		
		///<summary>
		/// 适用平台
		///</summary>
		
		private string platform_;
		
		///<summary>
		/// 0:已使用 1: 未使用 2:已废弃
		///</summary>
		
		private byte? status_;
		
		///<summary>
		/// 状态 0:未删除 1:已删除
		///</summary>
		
		private byte? isDeleted_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private long? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private long? updateTime_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetCouponNo(){
			return this.couponNo_;
		}
		
		public void SetCouponNo(string value){
			this.couponNo_ = value;
		}
		public string GetCouponSn(){
			return this.couponSn_;
		}
		
		public void SetCouponSn(string value){
			this.couponSn_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public byte? GetGroupType(){
			return this.groupType_;
		}
		
		public void SetGroupType(byte? value){
			this.groupType_ = value;
		}
		public long? GetActivateTime(){
			return this.activateTime_;
		}
		
		public void SetActivateTime(long? value){
			this.activateTime_ = value;
		}
		public long? GetUseTime(){
			return this.useTime_;
		}
		
		public void SetUseTime(long? value){
			this.useTime_ = value;
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
		public string GetBindOrderSn(){
			return this.bindOrderSn_;
		}
		
		public void SetBindOrderSn(string value){
			this.bindOrderSn_ = value;
		}
		public double? GetUseLimit(){
			return this.useLimit_;
		}
		
		public void SetUseLimit(double? value){
			this.useLimit_ = value;
		}
		public double? GetFavAmount(){
			return this.favAmount_;
		}
		
		public void SetFavAmount(double? value){
			this.favAmount_ = value;
		}
		public string GetPlatform(){
			return this.platform_;
		}
		
		public void SetPlatform(string value){
			this.platform_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		public byte? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(byte? value){
			this.isDeleted_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		
	}
	
}