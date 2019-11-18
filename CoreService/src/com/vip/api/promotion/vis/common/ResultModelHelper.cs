using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.common{
	
	
	
	public class ResultModelHelper : TBeanSerializer<ResultModel>
	{
		
		public static ResultModelHelper OBJ = new ResultModelHelper();
		
		public static ResultModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ResultModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsg(value);
					}
					
					
					
					
					
					if ("doNextStep".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetDoNextStep(value);
					}
					
					
					
					
					
					if ("fid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFid(value);
					}
					
					
					
					
					
					if ("errorMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetErrorMsg(value);
					}
					
					
					
					
					
					if ("totalCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalCount(value);
					}
					
					
					
					
					
					if ("successCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSuccessCount(value);
					}
					
					
					
					
					
					if ("failCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFailCount(value);
					}
					
					
					
					
					
					if ("noticeMsgList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem2;
								elem2 = iprot.ReadString();
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetNoticeMsgList(value);
					}
					
					
					
					
					
					if ("errorType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorType(value);
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
		
		
		public void Write(ResultModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteI32((int)structs.GetCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("code can not be null!");
			}
			
			
			if(structs.GetMsg() != null) {
				
				oprot.WriteFieldBegin("msg");
				oprot.WriteString(structs.GetMsg());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("msg can not be null!");
			}
			
			
			if(structs.GetDoNextStep() != null) {
				
				oprot.WriteFieldBegin("doNextStep");
				oprot.WriteBool((bool)structs.GetDoNextStep());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFid() != null) {
				
				oprot.WriteFieldBegin("fid");
				oprot.WriteString(structs.GetFid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorMsg() != null) {
				
				oprot.WriteFieldBegin("errorMsg");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetErrorMsg()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalCount() != null) {
				
				oprot.WriteFieldBegin("totalCount");
				oprot.WriteI32((int)structs.GetTotalCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccessCount() != null) {
				
				oprot.WriteFieldBegin("successCount");
				oprot.WriteI32((int)structs.GetSuccessCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailCount() != null) {
				
				oprot.WriteFieldBegin("failCount");
				oprot.WriteI32((int)structs.GetFailCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNoticeMsgList() != null) {
				
				oprot.WriteFieldBegin("noticeMsgList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetNoticeMsgList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorType() != null) {
				
				oprot.WriteFieldBegin("errorType");
				oprot.WriteString(structs.GetErrorType());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ResultModel bean){
			
			
		}
		
	}
	
}