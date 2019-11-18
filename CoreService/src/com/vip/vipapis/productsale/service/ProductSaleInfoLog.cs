using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vipapis.productsale.service{
	
	
	
	
	
	public class ProductSaleInfoLog {
		
		///<summary>
		/// 日志记录ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 商品销售记录ID
		///</summary>
		
		private string productSaleInfoId_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 部门
		///</summary>
		
		private string department_;
		
		///<summary>
		/// 更新内容
		///</summary>
		
		private string fieldName_;
		
		///<summary>
		/// 更新前
		///</summary>
		
		private string oldValue_;
		
		///<summary>
		/// 更新后
		///</summary>
		
		private string newValue_;
		
		///<summary>
		/// 创建时间,单位毫秒
		///</summary>
		
		private long? createTime_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetProductSaleInfoId(){
			return this.productSaleInfoId_;
		}
		
		public void SetProductSaleInfoId(string value){
			this.productSaleInfoId_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		public string GetDepartment(){
			return this.department_;
		}
		
		public void SetDepartment(string value){
			this.department_ = value;
		}
		public string GetFieldName(){
			return this.fieldName_;
		}
		
		public void SetFieldName(string value){
			this.fieldName_ = value;
		}
		public string GetOldValue(){
			return this.oldValue_;
		}
		
		public void SetOldValue(string value){
			this.oldValue_ = value;
		}
		public string GetNewValue(){
			return this.newValue_;
		}
		
		public void SetNewValue(string value){
			this.newValue_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		
	}
	
}