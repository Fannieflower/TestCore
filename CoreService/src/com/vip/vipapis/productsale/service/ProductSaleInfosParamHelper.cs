using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vipapis.productsale.service{
	
	
	
	public class ProductSaleInfosParamHelper : TBeanSerializer<ProductSaleInfosParam>
	{
		
		public static ProductSaleInfosParamHelper OBJ = new ProductSaleInfosParamHelper();
		
		public static ProductSaleInfosParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductSaleInfosParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("globalIds".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem0;
								elem0 = iprot.ReadI64(); 
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGlobalIds(value);
					}
					
					
					
					
					
					if ("serialNos".Equals(schemeField.Trim())){
						
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
						
						structs.SetSerialNos(value);
					}
					
					
					
					
					
					if ("vendorCodes".Equals(schemeField.Trim())){
						
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
						
						structs.SetVendorCodes(value);
					}
					
					
					
					
					
					if ("itemDescs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem3;
								elem3 = iprot.ReadString();
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItemDescs(value);
					}
					
					
					
					
					
					if ("itemNos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem4;
								elem4 = iprot.ReadString();
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItemNos(value);
					}
					
					
					
					
					
					if ("startTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetStartTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("auditStartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAuditStartTime(value);
					}
					
					
					
					
					
					if ("auditEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAuditEndTime(value);
					}
					
					
					
					
					
					if ("auditStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<byte?> value;
						
						value = new List<byte?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								byte elem5;
								elem5 = iprot.ReadByte(); 
								
								value.Add(elem5);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAuditStatus(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("limit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLimit(value);
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
		
		
		public void Write(ProductSaleInfosParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGlobalIds() != null) {
				
				oprot.WriteFieldBegin("globalIds");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetGlobalIds()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSerialNos() != null) {
				
				oprot.WriteFieldBegin("serialNos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSerialNos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCodes() != null) {
				
				oprot.WriteFieldBegin("vendorCodes");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetVendorCodes()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemDescs() != null) {
				
				oprot.WriteFieldBegin("itemDescs");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetItemDescs()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemNos() != null) {
				
				oprot.WriteFieldBegin("itemNos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetItemNos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStartTime() != null) {
				
				oprot.WriteFieldBegin("startTime");
				oprot.WriteI64((long)structs.GetStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAuditStartTime() != null) {
				
				oprot.WriteFieldBegin("auditStartTime");
				oprot.WriteI64((long)structs.GetAuditStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAuditEndTime() != null) {
				
				oprot.WriteFieldBegin("auditEndTime");
				oprot.WriteI64((long)structs.GetAuditEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAuditStatus() != null) {
				
				oprot.WriteFieldBegin("auditStatus");
				
				oprot.WriteListBegin();
				foreach(byte _item0 in structs.GetAuditStatus()){
					
					oprot.WriteByte((byte)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLimit() != null) {
				
				oprot.WriteFieldBegin("limit");
				oprot.WriteI32((int)structs.GetLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProductSaleInfosParam bean){
			
			
		}
		
	}
	
}