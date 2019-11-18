using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class AscBriefHelper : TBeanSerializer<AscBrief>
	{
		
		public static AscBriefHelper OBJ = new AscBriefHelper();
		
		public static AscBriefHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AscBrief structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("asc_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_sn(value);
					}
					
					
					
					
					
					if ("asc_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetAsc_type(value);
					}
					
					
					
					
					
					if ("asc_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_time(value);
					}
					
					
					
					
					
					if ("asc_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_status(value);
					}
					
					
					
					
					
					if ("refund_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_status(value);
					}
					
					
					
					
					
					if ("user_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_remark(value);
					}
					
					
					
					
					
					if ("image_urls".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetImage_urls(value);
					}
					
					
					
					
					
					if ("open_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpen_id(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(AscBrief structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_sn() != null) {
				
				oprot.WriteFieldBegin("asc_sn");
				oprot.WriteString(structs.GetAsc_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_type() != null) {
				
				oprot.WriteFieldBegin("asc_type");
				oprot.WriteByte((byte)structs.GetAsc_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_time() != null) {
				
				oprot.WriteFieldBegin("asc_time");
				oprot.WriteString(structs.GetAsc_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_status() != null) {
				
				oprot.WriteFieldBegin("asc_status");
				oprot.WriteString(structs.GetAsc_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefund_status() != null) {
				
				oprot.WriteFieldBegin("refund_status");
				oprot.WriteString(structs.GetRefund_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUser_remark() != null) {
				
				oprot.WriteFieldBegin("user_remark");
				oprot.WriteString(structs.GetUser_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImage_urls() != null) {
				
				oprot.WriteFieldBegin("image_urls");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetImage_urls()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpen_id() != null) {
				
				oprot.WriteFieldBegin("open_id");
				oprot.WriteString(structs.GetOpen_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AscBrief bean){
			
			
		}
		
	}
	
}