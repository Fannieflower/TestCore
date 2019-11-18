using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.delivery{
	
	
	
	
	
	public class Get3PLMultiPoPickDetailRequest {
		
		///<summary>
		/// 3PL运营商id
		///</summary>
		
		private int? operator_id_;
		
		///<summary>
		/// 拣货单编号
		///</summary>
		
		private string pick_no_;
		
		///<summary>
		/// 页码参数
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录条数，默认50，最大100
		///</summary>
		
		private int? limit_;
		
		public int? GetOperator_id(){
			return this.operator_id_;
		}
		
		public void SetOperator_id(int? value){
			this.operator_id_ = value;
		}
		public string GetPick_no(){
			return this.pick_no_;
		}
		
		public void SetPick_no(string value){
			this.pick_no_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}