using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.product{
	
	
	
	
	
	public class OnShelfResponse {
		
		///<summary>
		/// 更新时间,格式:yyyy-MM-dd HH:mm:SS
		///</summary>
		
		private string modify_time_;
		
		///<summary>
		/// 上架结果,其中key为spu_id，value为操作结果，true表示成功，false表示失败。（入参中的所有spu_id在该Map中都有对应的key-value）
		///</summary>
		
		private Dictionary<string, bool?> op_results_;
		
		///<summary>
		/// 详细上架结果，key为spu_id
		///</summary>
		
		private Dictionary<string, vipapis.marketplace.product.ShelfResult> shelf_results_;
		
		public string GetModify_time(){
			return this.modify_time_;
		}
		
		public void SetModify_time(string value){
			this.modify_time_ = value;
		}
		public Dictionary<string, bool?> GetOp_results(){
			return this.op_results_;
		}
		
		public void SetOp_results(Dictionary<string, bool?> value){
			this.op_results_ = value;
		}
		public Dictionary<string, vipapis.marketplace.product.ShelfResult> GetShelf_results(){
			return this.shelf_results_;
		}
		
		public void SetShelf_results(Dictionary<string, vipapis.marketplace.product.ShelfResult> value){
			this.shelf_results_ = value;
		}
		
	}
	
}