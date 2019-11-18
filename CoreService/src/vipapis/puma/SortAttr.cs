using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.puma{
	
	
	
	
	
	public class SortAttr {
		
		///<summary>
		/// 属性编码：2、价格  4、折扣 5、近30天销售额 6、近30天日平均销售量
		///</summary>
		
		private int? attr_code_;
		
		///<summary>
		/// 排序规则：1、升序  0、降序
		///</summary>
		
		private int? sort_rule_;
		
		public int? GetAttr_code(){
			return this.attr_code_;
		}
		
		public void SetAttr_code(int? value){
			this.attr_code_ = value;
		}
		public int? GetSort_rule(){
			return this.sort_rule_;
		}
		
		public void SetSort_rule(int? value){
			this.sort_rule_ = value;
		}
		
	}
	
}