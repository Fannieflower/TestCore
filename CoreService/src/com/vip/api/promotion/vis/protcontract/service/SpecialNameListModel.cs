using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class SpecialNameListModel {
		
		///<summary>
		/// 专场名称列表
		///</summary>
		
		private List<string> specialNameList_;
		
		public List<string> GetSpecialNameList(){
			return this.specialNameList_;
		}
		
		public void SetSpecialNameList(List<string> value){
			this.specialNameList_ = value;
		}
		
	}
	
}