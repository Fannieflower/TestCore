using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActScopeModel {
		
		///<summary>
		/// scopeId
		///</summary>
		
		private long? scopeId_;
		
		///<summary>
		/// 专场类型
		///</summary>
		
		private int? scopeType_;
		
		///<summary>
		/// 商品所在专场ID
		///</summary>
		
		private int? brandId_;
		
		///<summary>
		/// 商品所在专场名字
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 商品所在专场ID
		///</summary>
		
		private long? salesNo_;
		
		public long? GetScopeId(){
			return this.scopeId_;
		}
		
		public void SetScopeId(long? value){
			this.scopeId_ = value;
		}
		public int? GetScopeType(){
			return this.scopeType_;
		}
		
		public void SetScopeType(int? value){
			this.scopeType_ = value;
		}
		public int? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(int? value){
			this.brandId_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public long? GetSalesNo(){
			return this.salesNo_;
		}
		
		public void SetSalesNo(long? value){
			this.salesNo_ = value;
		}
		
	}
	
}