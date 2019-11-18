using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ConfirmationResult {
		
		///<summary>
		/// 确认函类型: 1-普通活动；2-优惠券；3-专享价；4-口令红包
		///</summary>
		
		private byte? type_;
		
		///<summary>
		/// 编号: type=1-活动编号；type=2-优惠券编号(couponSn)；type=3-专享价活动编号；type=4-口令id
		///</summary>
		
		private string no_;
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private string scheduleId_;
		
		///<summary>
		/// 供应商编号
		///</summary>
		
		private string supplierNo_;
		
		///<summary>
		/// 品牌ID
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 确认函信息
		///</summary>
		
		private com.vip.pms.data.service.ConfirmationInfo info_;
		
		///<summary>
		/// 商品merchandiseNo
		///</summary>
		
		private long? merchandiseNo_;
		
		///<summary>
		/// 活动开始时间，目前只有商品专享价才返回
		///</summary>
		
		private System.DateTime? actBeginTime_;
		
		public byte? GetType(){
			return this.type_;
		}
		
		public void SetType(byte? value){
			this.type_ = value;
		}
		public string GetNo(){
			return this.no_;
		}
		
		public void SetNo(string value){
			this.no_ = value;
		}
		public string GetScheduleId(){
			return this.scheduleId_;
		}
		
		public void SetScheduleId(string value){
			this.scheduleId_ = value;
		}
		public string GetSupplierNo(){
			return this.supplierNo_;
		}
		
		public void SetSupplierNo(string value){
			this.supplierNo_ = value;
		}
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public com.vip.pms.data.service.ConfirmationInfo GetInfo(){
			return this.info_;
		}
		
		public void SetInfo(com.vip.pms.data.service.ConfirmationInfo value){
			this.info_ = value;
		}
		public long? GetMerchandiseNo(){
			return this.merchandiseNo_;
		}
		
		public void SetMerchandiseNo(long? value){
			this.merchandiseNo_ = value;
		}
		public System.DateTime? GetActBeginTime(){
			return this.actBeginTime_;
		}
		
		public void SetActBeginTime(System.DateTime? value){
			this.actBeginTime_ = value;
		}
		
	}
	
}