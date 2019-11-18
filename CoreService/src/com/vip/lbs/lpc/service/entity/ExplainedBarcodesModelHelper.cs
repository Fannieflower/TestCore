using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.lpc.service.entity{
	
	
	
	public class ExplainedBarcodesModelHelper : TBeanSerializer<ExplainedBarcodesModel>
	{
		
		public static ExplainedBarcodesModelHelper OBJ = new ExplainedBarcodesModelHelper();
		
		public static ExplainedBarcodesModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExplainedBarcodesModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("serialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSerialNo(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("barCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarCode(value);
					}
					
					
					
					
					
					if ("toBeExplainedBarcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetToBeExplainedBarcode(value);
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
		
		
		public void Write(ExplainedBarcodesModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSerialNo() != null) {
				
				oprot.WriteFieldBegin("serialNo");
				oprot.WriteString(structs.GetSerialNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("serialNo can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetBarCode() != null) {
				
				oprot.WriteFieldBegin("barCode");
				oprot.WriteString(structs.GetBarCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barCode can not be null!");
			}
			
			
			if(structs.GetToBeExplainedBarcode() != null) {
				
				oprot.WriteFieldBegin("toBeExplainedBarcode");
				oprot.WriteString(structs.GetToBeExplainedBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("toBeExplainedBarcode can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExplainedBarcodesModel bean){
			
			
		}
		
	}
	
}