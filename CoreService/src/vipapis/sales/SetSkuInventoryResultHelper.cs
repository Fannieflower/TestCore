using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.sales{
	
	
	
	public class SetSkuInventoryResultHelper : TBeanSerializer<SetSkuInventoryResult>
	{
		
		public static SetSkuInventoryResultHelper OBJ = new SetSkuInventoryResultHelper();
		
		public static SetSkuInventoryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SetSkuInventoryResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("successList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.sales.BarcodeInventory> value;
						
						value = new List<vipapis.sales.BarcodeInventory>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.sales.BarcodeInventory elem0;
								
								elem0 = new vipapis.sales.BarcodeInventory();
								vipapis.sales.BarcodeInventoryHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSuccessList(value);
					}
					
					
					
					
					
					if ("failedList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.sales.BarcodeMessage> value;
						
						value = new List<vipapis.sales.BarcodeMessage>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.sales.BarcodeMessage elem2;
								
								elem2 = new vipapis.sales.BarcodeMessage();
								vipapis.sales.BarcodeMessageHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFailedList(value);
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
		
		
		public void Write(SetSkuInventoryResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSuccessList() != null) {
				
				oprot.WriteFieldBegin("successList");
				
				oprot.WriteListBegin();
				foreach(vipapis.sales.BarcodeInventory _item0 in structs.GetSuccessList()){
					
					
					vipapis.sales.BarcodeInventoryHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("successList can not be null!");
			}
			
			
			if(structs.GetFailedList() != null) {
				
				oprot.WriteFieldBegin("failedList");
				
				oprot.WriteListBegin();
				foreach(vipapis.sales.BarcodeMessage _item0 in structs.GetFailedList()){
					
					
					vipapis.sales.BarcodeMessageHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("failedList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SetSkuInventoryResult bean){
			
			
		}
		
	}
	
}