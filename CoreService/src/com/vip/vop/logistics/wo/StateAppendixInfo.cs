using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class StateAppendixInfo {
		
		///<summary>
		/// 是否处罚
		/// @sampleValue is_punish true
		///</summary>
		
		private bool? is_punish_;
		
		///<summary>
		/// 是否处罚
		/// @sampleValue is_expedited true
		///</summary>
		
		private bool? is_expedited_;
		
		///<summary>
		/// 是否联系不上
		/// @sampleValue is_contacted true
		///</summary>
		
		private bool? is_contacted_;
		
		///<summary>
		/// 催促次数：0-非催促，3-三催，4-四催，5-五催
		/// @sampleValue urges_cnt 3
		///</summary>
		
		private int? urges_cnt_;
		
		///<summary>
		/// 原因
		/// @sampleValue reason 
		///</summary>
		
		private string reason_;
		
		public bool? GetIs_punish(){
			return this.is_punish_;
		}
		
		public void SetIs_punish(bool? value){
			this.is_punish_ = value;
		}
		public bool? GetIs_expedited(){
			return this.is_expedited_;
		}
		
		public void SetIs_expedited(bool? value){
			this.is_expedited_ = value;
		}
		public bool? GetIs_contacted(){
			return this.is_contacted_;
		}
		
		public void SetIs_contacted(bool? value){
			this.is_contacted_ = value;
		}
		public int? GetUrges_cnt(){
			return this.urges_cnt_;
		}
		
		public void SetUrges_cnt(int? value){
			this.urges_cnt_ = value;
		}
		public string GetReason(){
			return this.reason_;
		}
		
		public void SetReason(string value){
			this.reason_ = value;
		}
		
	}
	
}