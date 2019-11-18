using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ConfirmationInfo {
		
		///<summary>
		/// 确认函编号
		///</summary>
		
		private string confirmNo_;
		
		///<summary>
		/// 分摊比例
		///</summary>
		
		private double? supplierScale_;
		
		///<summary>
		/// 数据类型: 3-供应商比例；4-供应商确认函
		///</summary>
		
		private byte? dataType_;
		
		///<summary>
		/// 新流程承担方式  -1:旧流程  0:唯品会承担；1:供应商承担  2:扣点方式  3:x比例模式  4:固定比例
		///</summary>
		
		private short? chargeType_;
		
		public string GetConfirmNo(){
			return this.confirmNo_;
		}
		
		public void SetConfirmNo(string value){
			this.confirmNo_ = value;
		}
		public double? GetSupplierScale(){
			return this.supplierScale_;
		}
		
		public void SetSupplierScale(double? value){
			this.supplierScale_ = value;
		}
		public byte? GetDataType(){
			return this.dataType_;
		}
		
		public void SetDataType(byte? value){
			this.dataType_ = value;
		}
		public short? GetChargeType(){
			return this.chargeType_;
		}
		
		public void SetChargeType(short? value){
			this.chargeType_ = value;
		}
		
	}
	
}