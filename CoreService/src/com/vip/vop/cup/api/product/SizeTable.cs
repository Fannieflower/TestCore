using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class SizeTable {
		
		///<summary>
		/// ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 类型，1：标准尺码表，2：简单尺码表
		///</summary>
		
		private short? type_;
		
		///<summary>
		/// Html内容，类型为2时有效
		///</summary>
		
		private string html_;
		
		///<summary>
		/// 温馨提示，类型为1时有效
		///</summary>
		
		private string tips_;
		
		///<summary>
		/// 删除标记(默认0，1已删除)
		///</summary>
		
		private short? del_flag_;
		
		///<summary>
		/// 尺码表详情集
		///</summary>
		
		private Dictionary<long?, com.vip.vop.cup.api.product.SizeDetail> details_;
		
		///<summary>
		/// 尺码推荐内容，格式为json v{'XS':[{'height':'165','weight':'50'},{'height':'170','weight':'55'}]}
		///</summary>
		
		private string recommend_info_;
		
		///<summary>
		/// 尺码Json
		///</summary>
		
		private string json_data_;
		
		///<summary>
		/// 尺码类型ID
		///</summary>
		
		private int? size_type_id_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public short? GetType(){
			return this.type_;
		}
		
		public void SetType(short? value){
			this.type_ = value;
		}
		public string GetHtml(){
			return this.html_;
		}
		
		public void SetHtml(string value){
			this.html_ = value;
		}
		public string GetTips(){
			return this.tips_;
		}
		
		public void SetTips(string value){
			this.tips_ = value;
		}
		public short? GetDel_flag(){
			return this.del_flag_;
		}
		
		public void SetDel_flag(short? value){
			this.del_flag_ = value;
		}
		public Dictionary<long?, com.vip.vop.cup.api.product.SizeDetail> GetDetails(){
			return this.details_;
		}
		
		public void SetDetails(Dictionary<long?, com.vip.vop.cup.api.product.SizeDetail> value){
			this.details_ = value;
		}
		public string GetRecommend_info(){
			return this.recommend_info_;
		}
		
		public void SetRecommend_info(string value){
			this.recommend_info_ = value;
		}
		public string GetJson_data(){
			return this.json_data_;
		}
		
		public void SetJson_data(string value){
			this.json_data_ = value;
		}
		public int? GetSize_type_id(){
			return this.size_type_id_;
		}
		
		public void SetSize_type_id(int? value){
			this.size_type_id_ = value;
		}
		
	}
	
}