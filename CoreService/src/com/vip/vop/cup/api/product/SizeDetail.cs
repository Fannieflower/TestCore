using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class SizeDetail {
		
		///<summary>
		/// ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 尺码名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 属性值
		///</summary>
		
		private Dictionary<string, string> property_values_;
		
		///<summary>
		/// 属性模型定义,描述了使用的属性及别名，多个属性之间用逗号隔开:前浪，后浪，腰围
		///</summary>
		
		private string dimension_;
		
		///<summary>
		/// 默认0，1已删除
		///</summary>
		
		private short? del_flag_;
		
		///<summary>
		/// 尺码表明细顺序
		///</summary>
		
		private int? size_detail_order_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public Dictionary<string, string> GetProperty_values(){
			return this.property_values_;
		}
		
		public void SetProperty_values(Dictionary<string, string> value){
			this.property_values_ = value;
		}
		public string GetDimension(){
			return this.dimension_;
		}
		
		public void SetDimension(string value){
			this.dimension_ = value;
		}
		public short? GetDel_flag(){
			return this.del_flag_;
		}
		
		public void SetDel_flag(short? value){
			this.del_flag_ = value;
		}
		public int? GetSize_detail_order(){
			return this.size_detail_order_;
		}
		
		public void SetSize_detail_order(int? value){
			this.size_detail_order_ = value;
		}
		
	}
	
}