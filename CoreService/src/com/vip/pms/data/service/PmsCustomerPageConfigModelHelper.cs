using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsCustomerPageConfigModelHelper : TBeanSerializer<PmsCustomerPageConfigModel>
	{
		
		public static PmsCustomerPageConfigModelHelper OBJ = new PmsCustomerPageConfigModelHelper();
		
		public static PmsCustomerPageConfigModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsCustomerPageConfigModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("configPage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigPage(value);
					}
					
					
					
					
					
					if ("configValueList".Equals(schemeField.Trim())){
						
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
						
						structs.SetConfigValueList(value);
					}
					
					
					
					
					
					if ("configDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigDesc(value);
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
		
		
		public void Write(PmsCustomerPageConfigModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetConfigPage() != null) {
				
				oprot.WriteFieldBegin("configPage");
				oprot.WriteString(structs.GetConfigPage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetConfigValueList() != null) {
				
				oprot.WriteFieldBegin("configValueList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetConfigValueList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("configValueList can not be null!");
			}
			
			
			if(structs.GetConfigDesc() != null) {
				
				oprot.WriteFieldBegin("configDesc");
				oprot.WriteString(structs.GetConfigDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsCustomerPageConfigModel bean){
			
			
		}
		
	}
	
}