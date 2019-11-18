using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ConfirmationRequest {
		
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
		/// 商品merchandiseNo
		///</summary>
		
		private List<long?> merchandiseNos_;
		
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
		public List<long?> GetMerchandiseNos(){
			return this.merchandiseNos_;
		}
		
		public void SetMerchandiseNos(List<long?> value){
			this.merchandiseNos_ = value;
		}
		
	}
	
}